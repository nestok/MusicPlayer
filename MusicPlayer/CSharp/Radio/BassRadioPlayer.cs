using System;
using Lastfm.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;
using System.Windows.Forms;

namespace MusicPlayer
{
    public static class BassRadioPlayer
    {
        public static int RadioStream;
        public static int Volume;
        public static async void startBassStream(string files, int vol)
        {
            await Task.Run(() =>
            {
                Bass.BASS_StreamFree(RadioStream);

                Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_ASYNCFILE_BUFFER, 5000);
                Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATEPERIOD, 5000);
                RadioStream = Bass.BASS_StreamCreateURL(files, 0, BASSFlag.BASS_STREAM_AUTOFREE | BASSFlag.BASS_STREAM_STATUS, null, IntPtr.Zero);
                TagRadioManager.syncStreamTitleUpdates(RadioStream);
                if (RadioStream != 0 && Bass.BASS_ChannelPlay(RadioStream, true))
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(RadioStream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100.0F);
                    TagRadioManager.updateTags();
                }
                else
                {
                    MessageBox.Show("Радиостанция в данный момент недоступна.\nПроверьте интернет-соединение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            });
        }

        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
    }
}
