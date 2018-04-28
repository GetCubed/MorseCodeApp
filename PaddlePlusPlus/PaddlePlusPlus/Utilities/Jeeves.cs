using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace PaddlePlusPlus.Utilities
{
    class Jeeves
    {
        //-------------------LOCAL API-------------------
        //public static Uri DBUri = new Uri("http://localhost:61816//");

        //-------------------PAID API FOR MORSE SOUND CONVERSION-------------------
        //public static Uri DBUri = new Uri("http://api.funtranslations.com/translate//"); 

        //-------------------FREE API FOR APP TESTING-------------------
        public static Uri DBUri = new Uri("http://www.morsecode-api.de//"); 


        internal async static void ShowMessage(string strTitle, string Msg)
        {
            ContentDialog diag = new ContentDialog()
            {
                Title = strTitle,
                Content = Msg,
                PrimaryButtonText = "Ok"
            };
            await diag.ShowAsync();
        }

    }



}
