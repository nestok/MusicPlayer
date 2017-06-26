using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using Un4seen.Bass;
using System.IO;
using System.Runtime.InteropServices;

namespace MusicPlayer
{
    public static class Client
    {
        public static bool connected = false;
        private const int remotePort = 11000;
        private const int localPort = 11000;
        //public static byte[] _data = null; // our local buffer 
        //public static STREAMPROC _myStreamCreate; 

        //public static UdpClient receiver;// = new UdpClient(localPort); 
        //public static IPEndPoint remoteIp;// = new IPEndPoint(IPAddress.Parse("192.168.0.101"), 11000); 
        static public void ClientThread(Object stateInfo)
        {
            int stream = 0;

            UdpClient receiver = new UdpClient(localPort);
            IPEndPoint remoteIp = new IPEndPoint(IPAddress.Any, 11000);
            try
            {
                //receiver = new UdpClient(localPort); 
                //remoteIp = new IPEndPoint(IPAddress.Parse("192.168.0.101"), 11000); 
                stream = Bass.BASS_StreamCreatePush(44100, 2, BASSFlag.BASS_DEFAULT, IntPtr.Zero);
                Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, 0.5f);
                Bass.BASS_ChannelPlay(stream, false);
                //_myStreamCreate = new STREAMPROC(MyFileProc); 
                //int channel = Bass.BASS_StreamCreate(44100, 2, BASSFlag.BASS_DEFAULT, _myStreamCreate, IntPtr.Zero); 
                //Bass.BASS_ChannelPlay(channel, false); 
                while (connected)
                {
                    byte[] data = receiver.Receive(ref remoteIp);
                    Bass.BASS_StreamPutData(stream, data, data.Length);
                    Bass.BASS_ErrorGetCode();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Bass.BASS_ChannelStop(stream);
                receiver.Close();
            }

        }

        //public static int MyFileProc(int handle, IntPtr buffer, int length, IntPtr user) 
        //{ 
        // MemoryStream ms = new MemoryStream(); 
        // //if (_data == null || _data.Length < length) 
        // // _data = new byte[length]; 
        // _data = receiver.Receive(ref remoteIp); 
        // ms.Write(_data, 0, _data.Length); 
        // int bytesread = ms.Read(_data, 0, _data.Length); 
        // Marshal.Copy(_data, 0, buffer, 1024); 
        // //if (bytesread < _data.Length) 
        // //{ 
        // // // set indicator flag 
        // // bytesread |= (int)BASSStreamProc.BASS_STREAMPROC_END; 
        // // ms.Close(); 
        // //} 
        // ms.Close(); 
        // return 1024; 
        //} 




        public static string LocalIPAddress()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
    }
}