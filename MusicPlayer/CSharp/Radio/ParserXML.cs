using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
namespace MusicPlayer
{
    public class ParserXML
    {
        public static List<Station> stations;
        static ParserXML()
        {
            loadPlayList();
        }

        private static void loadPlayList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Station>));
            using (FileStream fs = new FileStream("RadioStations.xml", FileMode.OpenOrCreate))
            {
                stations = (List<Station>)formatter.Deserialize(fs);
            }
        }

        public static void addNewStation(String url, String name, String image)
        {
            stations.Add(new Station() { Name = name, Url = url, Image = image });
            savePlayList();
        }

        public static void deleteStation(int id)
        {
            stations.RemoveAt(id);
            savePlayList();
        }

        public static void savePlayList()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Station>));

            using (FileStream fs = new FileStream("RadioStations.xml", FileMode.Create))
            {
                formatter.Serialize(fs, stations);
            }
        }
    }
}
