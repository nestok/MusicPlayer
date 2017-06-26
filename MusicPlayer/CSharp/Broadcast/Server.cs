using System;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Net.Sockets;
using Un4seen.Bass;

namespace MusicPlayer
{
    public class Server
    {
        public static bool connected = false;
        public static string Client_IP;
        public static void Music_Input(Object arg)
        {
            int stream = (int)arg;
            UdpClient sender = new UdpClient();
            IPEndPoint endPoint = null;
            try
            {
                endPoint = new IPEndPoint(IPAddress.Parse(Client_IP), 11000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client ip input error:" + ex);
            }
            try
            {
                while (connected)
                {
                    byte[] buf = new byte[1024];
                    Bass.BASS_ChannelGetData(stream, buf, (int)BASSData.BASS_DATA_FFT256);
                    sender.Send(buf, buf.Length, endPoint);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sender.Close();
            }
        }

    }
}