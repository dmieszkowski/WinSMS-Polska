using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string Name { get; set; }

        public string Fixed { get { return Name + " (" + Number + ")"; } }

        public override string ToString()
        {
            return Fixed;
        }

    }
}
