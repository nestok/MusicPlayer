using Lastfm.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;


namespace MusicPlayer
{
    public class TagRadioManager
    {
        public static event EventHandler<TagsEventArgs> NewTagEvent = delegate{};
        public static TagInfoRadio titleArtist = new TagInfoRadio();
        public static TAG_INFO _tags;
        public static SYNCPROC _mySync;

        public static void syncStreamTitleUpdates(int channel)
        {
            _tags = new TAG_INFO();
            _mySync = new SYNCPROC(metaSync);
            Bass.BASS_ChannelSetSync(channel, BASSSync.BASS_SYNC_META, 0, _mySync, IntPtr.Zero);
        }

        private static void metaSync(int handle, int channel, int data, IntPtr user)
        {
            user = Bass.BASS_ChannelGetTags(channel, BASSTag.BASS_TAG_META);
            _tags.UpdateFromMETA(user, TAGINFOEncoding.Ansi, false);
            updateTags();
        }

        public static void updateTags()
        {

            if (BassTags.BASS_TAG_GetFromURL(BassRadioPlayer.RadioStream, _tags) && _tags.artist != " ")
            {
                titleArtist.Artist = _tags.artist;
                titleArtist.Titles = _tags.title;
            }
            else if (_tags != null)
            {
                titleArtist.Artist = _tags.album;
                titleArtist.Titles = _tags.comment;

            }
            EventHandler<TagsEventArgs> temp = NewTagEvent;
            temp.Invoke(null, new TagsEventArgs(titleArtist));
        }
    }

    public sealed class TagsEventArgs : EventArgs
    {
        private readonly TagInfoRadio tagInfo;

        public TagInfoRadio TagProp 
        {
            get { return tagInfo; }
        }
        public TagsEventArgs(TagInfoRadio tag)
        {
            tagInfo = tag; 
        }
    }
}
