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
        //public static Uri DBUri = new Uri("http://localhost:61816//");
        //public static Uri DBUri = new Uri("http://progwebapi.azurewebsites.net//");
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
