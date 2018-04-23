using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.Media.Core;
using Windows.Storage;
using Windows.ApplicationModel;

namespace PaddlePlusPlus.Utilities
{
    public static class DitSoundManager
    {

        static MediaPlayer player = new MediaPlayer();
        static StorageFolder folder;
        static StorageFile file550Hz;
        static StorageFile file550Hzshort;

        public static async void setSource()
        {
            folder = await Package.Current.InstalledLocation.GetFolderAsync(@"tones");
            file550Hz = await folder.GetFileAsync(@"550Hz.wav");
            file550Hzshort = await folder.GetFileAsync(@"550Hzshort.wav");
            player.AutoPlay = false; 
        }

        public static void play550Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file550Hz);
            player.Play();
        }

        public static void play550Hzshort()
        {
            player.Source = MediaSource.CreateFromStorageFile(file550Hzshort);
            player.Play();
        }

        public static void stopPlaying()
        {
            player.Pause();
        }

    }


    public static class DahSoundManager
    {

        static MediaPlayer player = new MediaPlayer();
        static StorageFolder folder;
        static StorageFile file540Hz;
        static StorageFile file545Hz;
        static StorageFile file550Hz;

        public static async void setSource()
        {
            folder = await Package.Current.InstalledLocation.GetFolderAsync(@"tones");
            file540Hz = await folder.GetFileAsync(@"540Hz.wav");
            file545Hz = await folder.GetFileAsync(@"545Hz.wav");
            file550Hz = await folder.GetFileAsync(@"550Hz.wav");
            player.AutoPlay = false;
        }


        public static void play540Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file540Hz);
            player.Play();
        }

        public static void play545Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file545Hz);
            player.Play();
        }

        public static void play550Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file550Hz);
            player.Play();
        }

        public static void stopPlaying()
        {
            player.Pause();
        }

    }

}
