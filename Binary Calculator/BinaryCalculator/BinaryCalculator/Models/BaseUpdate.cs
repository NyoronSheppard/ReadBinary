using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Models
{
    public static class BaseUpdate
    {
        //Button 1 Base (Changed)
        public static string nameBase1;
        public static string nameShortBase1;

        //Button 2 Base
        public static string nameBase2;
        public static string nameShortBase2;

        //Button 3 Base
        public static string nameBase3;
        public static string nameShortBase3;

        //Button 4 Base
        public static string nameBase4;
        public static string nameShortBase4;

        //Fist time
        public static bool firstTime;

        public static void first()
        {
            nameBase1 = "Decimal";
            nameShortBase1 = "DEC";

            nameBase2 = "Binary";
            nameShortBase2 = "BIN";

            nameBase3 = "Octal";
            nameShortBase3 = "OCT";

            nameBase4 = "Decimal";
            nameShortBase4 = "DEC";

            firstTime = true;
        }
    }
}
