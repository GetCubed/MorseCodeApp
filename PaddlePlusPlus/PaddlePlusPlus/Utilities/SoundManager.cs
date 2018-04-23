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
        static bool playing = false;
        static StorageFolder folder;
        static StorageFile file550Hz;
        static StorageFile file520Hz;


        public static async void setSource()
        {
            folder = await Package.Current.InstalledLocation.GetFolderAsync(@"tones");
            file550Hz = await folder.GetFileAsync(@"550HzAlt.wav");
            file520Hz = await folder.GetFileAsync(@"520Hz.wav");
            player.AutoPlay = false;
        }

        public static void play550Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file550Hz);

            player.Play();
            playing = true;
        }

        public static void play520Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file520Hz);

            player.Play();
            playing = true;
        }


        public static void stopPlaying()
        {
            player.Pause();

            playing = false;
        }

    }


    public static class DahSoundManager
    {

        static MediaPlayer player = new MediaPlayer();
        static bool playing = false;
        static StorageFolder folder;
        static StorageFile file550Hz;
        static StorageFile file520Hz;


        public static async void setSource()
        {
            folder = await Package.Current.InstalledLocation.GetFolderAsync(@"tones");
            file550Hz = await folder.GetFileAsync(@"550HzAlt.wav");
            file520Hz = await folder.GetFileAsync(@"520Hz.wav");
            player.AutoPlay = false;
        }

        public static void play550Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file550Hz);

            player.Play();
            playing = true;
        }

        public static void play520Hz()
        {
            player.Source = MediaSource.CreateFromStorageFile(file520Hz);

            player.Play();
            playing = true;
        }


        public static void stopPlaying()
        {
            player.Pause();

            playing = false;
        }

    }

}
