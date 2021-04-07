using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PaninTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input value : ");
            var values = Console.ReadLine();
            int value;


            if (int.TryParse(values, out value))
            {
                if (values.Length > 1)
                {
                    char tempStr;

                    var length = values.Length;
                    for (int i = 0; i < values.Length; i++)
                    {
                        tempStr = values[i];

                        var SB = new StringBuilder();
                        SB.Append(tempStr);
                        length = length - 1;
                        for (var x = 0; x < length; x++)
                        {
                            var zero = "0";
                            SB.Append(zero);
                        }
                        Console.WriteLine(SB.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Message : Your input is invalid, please try to input numeric.");
            }

            Console.WriteLine("Press Enter to Exit . .");
            Console.ReadKey();
            
        }
    }
}
