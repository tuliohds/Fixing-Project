using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixing
{
    class Fixing_Class
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }

        public string ResText1 { get; set; }
        public string ResText2 { get; set; }
        public string ResText3 { get; set; }

        public string ResFixText1 { get; set; }
        public string ResFixText2 { get; set; }
        public string ResFixText3 { get; set; }

        public static Fixing_Class instance;

        // Singleton 
        public static Fixing_Class getInstance()
        {
            if (instance == null)//Caso instancia seja null 
                instance = new Fixing_Class();//instancia igual classe

            return instance;
        }
    }
}
