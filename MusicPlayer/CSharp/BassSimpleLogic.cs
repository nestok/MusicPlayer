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
    public class BassSimpleLogic
    {
        public int samplingFrequency = 44100;
        public bool InitDefaultDevice;
        public int Stream;
        public bool isPlaing;
        public int Volume = 50;
        public bool EndPlayList;
        public TagInfoRadio radioTags;
        private readonly List<int> BassPluginsHandles = new List<int>();
        public bool InitBass(int samplingFrequency)
        {
            //try
            //{
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bass_aac.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bass_ac3.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bass_ape.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bass_mpc.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bass_tta.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bassalac.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bassflac.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/bassopus.dll"));
            //    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Files.AppPath + @"plugins/basswv.dll"));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error bass plugin load");
            //}
            //
            int ErrorCount = 0;
            for (int i = 0; i < BassPluginsHandles.Count; i++)
                if (BassPluginsHandles[i] == 0)
                    ErrorCount++;
            if (ErrorCount != 0)
                MessageBox.Show(ErrorCount + " plugins aren't load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return InitDefaultDevice;
        }

        public void Play(string filename, int vol)
        {
            if ((Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED) && (!isPlaing))
            {
                Stop();
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if (Stream != 0)
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);
            isPlaing = true;
        }

        public void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Stream);
            isPlaing = false;
        }

        public void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isPlaing = false;
        }

        public int GetTimeOfStream(int stream)
        {
            long timeBytes = Bass.BASS_ChannelGetLength(stream);
            double time = Bass.BASS_ChannelBytes2Seconds(stream, timeBytes);
            return (int)time;
        }

        public int GetLengthOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetLength(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public int GetPositionOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }

        public void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        public bool ToNextTrack()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (isPlaing))
            {
                if (Files.files.Count > Files.CurrentTrackNumber + 1)
                {
                    Play(Files.files[++Files.CurrentTrackNumber], Volume);
                    EndPlayList = false;
                    return true;
                }
                else
                    EndPlayList = true;
            }
            return false;
        }
    }
}
