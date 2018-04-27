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
using PaddlePlusPlus.DAL;
using PaddlePlusPlus.Models;





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

            askAPI("HELLO");
;
            MorseWriter.write("WORKS");

        }
        
        bool notPressedX = true;
        bool notPressedZ = true;
        int maxLength = 5;

        StringBuilder inputDisplay = new StringBuilder("");
        StringBuilder inputConvert = new StringBuilder("");
        StringBuilder outputDisplay = new StringBuilder("");
        StringBuilder outputWordToAdd = new StringBuilder("");
        StringBuilder wordToAdd = new StringBuilder("");
        StringBuilder wordOnDeck = new StringBuilder("");
        StringBuilder wordOnDeckPrime = new StringBuilder("");

        string letterOnDeck;
       
        Ch enumOnDeck;

        private void txtInput_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {

            if (e.Key == VirtualKey.Left)
            {
                if (lblWordOnDeck.Text != "")
                {
                    wordOnDeck.Clear();

                    inputDisplay.Clear();
                    inputConvert.Clear();

                    lblWordOnDeck.Text = "";
                }
                else
                {
                    outputDisplay.Clear();
                    txtOutput.Text = outputDisplay.ToString();
                    txtOutputText.Text = outputDisplay.ToString();
                }
                
                DahSoundManager.setSource();
                DitSoundManager.setSource();
            }
            else if (e.Key == VirtualKey.Right)
            {
                if (letterOnDeck == "")
                {
                    outputDisplay.Append(wordOnDeck.ToString() + " ");

                    txtOutput.Text = outputDisplay.ToString();
                    txtOutputText.Text = outputDisplay.ToString();
         
                    lblWordOnDeck.Text = "";

                    wordOnDeck.Clear();
                }
                else
                {
                    if (letterOnDeck != "#")
                    {
                        wordOnDeck.Append(letterOnDeck);
                    }
                    else
                    {
                        lblWordOnDeck.Text = wordOnDeck.ToString();
                    }
                   
                }


                inputDisplay.Clear();
                inputConvert.Clear();
                letterOnDeck = "";
                DahSoundManager.setSource();
                DitSoundManager.setSource();
                
            }
            else if (e.Key == VirtualKey.Z && notPressedZ)
            {
                if (inputDisplay.Length < maxLength)
                {
                    inputDisplay.Append(".");
                    inputConvert.Append("z");

                    enumOnDeck = Converter.morseStringToEnum(inputConvert.ToString());     
                    letterOnDeck = Converter.EnumToString(enumOnDeck);

                    lblWordOnDeck.Text = wordOnDeck.ToString() + letterOnDeck;

                    notPressedZ = false;
                    DahSoundManager.stopPlaying();
                    DitSoundManager.play550Hzshort();
                }
                
            }
            else if (e.Key == VirtualKey.X && notPressedX)
            {

                if (inputDisplay.Length < maxLength)
                {
                    inputDisplay.Append("-");
                    inputConvert.Append("x");

                    enumOnDeck = Converter.morseStringToEnum(inputConvert.ToString());
                    letterOnDeck = Converter.EnumToString(enumOnDeck);

                    lblWordOnDeck.Text = wordOnDeck.ToString() + letterOnDeck;

                    notPressedX = false;
                    DitSoundManager.stopPlaying();
                    DahSoundManager.play545Hz();
                }
  
            }
            else
            {
                DitSoundManager.stopPlaying();
                DahSoundManager.stopPlaying();
            }
            txtInput.Text = inputDisplay.ToString();
        }

        private void txtInput_PreviewKeyUp(object sender, KeyRoutedEventArgs e)
        {
            
            if (e.Key == VirtualKey.Z)
            {
                notPressedZ = true;
                DitSoundManager.stopPlaying();
            }
            else if (e.Key == VirtualKey.X)
            {
                notPressedX = true;
                DahSoundManager.stopPlaying();
            }
            else if (e.Key == VirtualKey.Right)
            {           
                DahSoundManager.setSource();
            }
        }


        private async void showMorseCode(string text)
        {

            MorseCodeRespository r = new MorseCodeRespository();
            try
            {
                MorseCode morseCode = new MorseCode();
                morseCode.morsecode = "";
                morseCode.plaintext = "";
                if (text != "")
                {
                    morseCode = await r.EncodeByStringAsync(text);
                }

                txtAPITextTest.Text = morseCode.morsecode;

            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message.Contains("server"))
                {
                    Jeeves.ShowMessage("Error", "No connection with the server.");
                }
                else
                {
                    Jeeves.ShowMessage("Error", "Could not complete operation.");
                }
            }

        }




        private void askAPI(string text)
        {
            showMorseCode(text);
        }
    }
}
