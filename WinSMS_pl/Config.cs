using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Com
{
    [DataContract]
    public class Config
    {
        [DataMember]
        public string Signature { get; set; }
        [DataMember]
        public List<Contact> Recipients { get; set; }
        [DataMember]
        public List<Contact> Senders { get; set; }
        [DataMember]
        public int DefaultRecipient { get; set; }
        [DataMember]
        public int DefaultSender { get; set; }
        [DataMember]
        public int DefaultSignatureType { get; set; }

        public Config()
        {
            Recipients = new List<Contact>();
            Senders = new List<Contact>();
        }
    }
}
