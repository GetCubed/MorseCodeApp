using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;
using PaddlePlusPlus.Utilities;





// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PaddlePlusPlus
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        
        public MainPage()
        {
            this.InitializeComponent();
            DitSoundManager.setSource();
            DahSoundManager.setSource();
        }


        bool notPressed = true;
        StringBuilder inputDisplay = new StringBuilder("");

        private void txtInput_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Right && notPressed)
            {
                inputDisplay.Clear();
                notPressed = false;              
            }
            else if (e.Key == VirtualKey.Z && notPressed)
            {
                inputDisplay.Append(".");
                notPressed = false;
                DahSoundManager.stopPlaying();
                DitSoundManager.play550Hz();       
            }
            else if (e.Key == VirtualKey.X && notPressed)
            {
                inputDisplay.Append("-");
                notPressed = false;
                DitSoundManager.stopPlaying();
                DahSoundManager.play520Hz();
            }
            else
            {
            }


            txtInput.Text = inputDisplay.ToString();

        }

        
        private void txtInput_PreviewKeyUp(object sender, KeyRoutedEventArgs e)
        {
            
            if (e.Key == VirtualKey.Z)
            {
                notPressed = true;
                DitSoundManager.stopPlaying();
            }
            else if (e.Key == VirtualKey.X)
            {
                notPressed = true;
                DahSoundManager.stopPlaying();
            }
            else if (e.Key == VirtualKey.Right)
            {
                notPressed = true;
            }
        }
    }
}
