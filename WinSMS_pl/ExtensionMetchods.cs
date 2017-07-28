using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class ExtensionMethods
{
    public static T DeserializeJson<T>(this string json)
    {
        var serializer = new DataContractJsonSerializer(typeof(T));

        using (var stream = new MemoryStream(Encoding.Default.GetBytes(json)))
        {
            return (T)serializer.ReadObject(stream);
        }
    }

    public static string ToJson<T>(this T data)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

        using (MemoryStream ms = new MemoryStream())
        {
            serializer.WriteObject(ms, data);
            return Encoding.Default.GetString(ms.ToArray());
        }
    }

    public static T JsonDeserialize<T>(this string json)
    {
        var serializer = new DataContractJsonSerializer(typeof(T));

        using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
            return (T)serializer.ReadObject(stream);
        }
    }

    [DllImport("user32.dll")]
    public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

    public static Bitmap CaptureWindow(this Control ctl)
    {
        Bitmap bmp = new Bitmap(ctl.ClientRectangle.Width, ctl.ClientRectangle.Height);  // content only
        using (Graphics graphics = Graphics.FromImage(bmp))
        {
            IntPtr hDC = graphics.GetHdc();
            try { PrintWindow(ctl.Handle, hDC, (uint)0); }
            finally { graphics.ReleaseHdc(hDC); }
        }
        return bmp;
    }
    public static Bitmap CaptureWindow(this Control ctl, Rectangle r)
    {
        Bitmap bmp = ctl.CaptureWindow();
        bmp = bmp.Clone(r, System.Drawing.Imaging.PixelFormat.Undefined);
        return bmp;
    }
}
