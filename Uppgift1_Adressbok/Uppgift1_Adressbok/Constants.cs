using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Uppgift1_Adressbok
{
    public class Constants
    {
        public static string PathToTxtFile
        {
            //get { return @"C:\Users\madok\Desktop\Nackademin\c#\Uppgifter\Uppgift1_Adressbok\AddressBook.txt"; }
            get
            {
                return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AddressBook.txt");
            }
        }
    }
}
