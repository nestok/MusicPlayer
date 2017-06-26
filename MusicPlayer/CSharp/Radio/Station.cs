using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MusicPlayer
{
    [Serializable]
    public class Station
    {
        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public string Image;
        [XmlAttribute]
        public string Url;
    }
}