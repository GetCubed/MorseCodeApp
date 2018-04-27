using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddlePlusPlus.Models
{


    public class Rootobject
    {
        public Success success { get; set; }
        public Contents contents { get; set; }
    }

    public class Success
    {
        public int total { get; set; }
    }

    public class Contents
    {
        public Translated translated { get; set; }
        public string text { get; set; }
        public string speed { get; set; }
        public string tone { get; set; }
        public Translation translation { get; set; }
    }

    public class Translated
    {
        public string audio { get; set; }
    }

    public class Translation
    {
        public string source { get; set; }
        public string destination { get; set; }
    }



}
