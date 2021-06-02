using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Part5.Models;
using Part5.ServiceReference1;

namespace Part5.Helper
{
    public class ProcessString
    {
         

        public static string Convert(string value, int id)
        {
            ConvertCaseSoapClient conv =
            new ConvertCaseSoapClient();

            try
            {


                switch (id)
                {
                    case 1:
                        value = conv.ToLowerCase(value);
                        break;
                    case 2:
                        value = conv.ToUpperCase(value);
                        break;
                    case 3:
                        value = conv.InvertCase(value);
                        break;
                    default: throw new Exception("Unknown value passed");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
    }
}