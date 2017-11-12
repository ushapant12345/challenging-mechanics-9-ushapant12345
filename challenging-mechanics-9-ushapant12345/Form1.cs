using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenging_mechanics_9_ushapant12345
{
    public partial class Form1 : Form
    {
        string str2 = "abcdefghijklmnoprstuvwxyz";
        string strOut = "";
        public Form1()
        {
            InitializeComponent();

            string str = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int charCount = 0;

            //is less than b
            for (int sndx = 0; sndx < str.Length; sndx++)
            {
                char cChar = str[sndx];
                if (cChar < 'b')
                {
                    charCount++;
                }
            }

            Console.WriteLine(charCount.ToString());

            // is greater than b
            int charCount1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'b')
                {
                    charCount1++;
                }
            }

            Console.WriteLine(charCount1.ToString());


            // is less than X
            int charCount2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'X')
                {
                    charCount2++;
                }
            }

            Console.WriteLine(charCount2.ToString());



            // is not equal to Y
            int charCount3 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'Y')
                {
                    charCount3++;
                }
            }

            Console.WriteLine(charCount3.ToString());



            // is less than d
            int charCount4 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'd')
                {
                    charCount4++;
                }
            }

            Console.WriteLine(charCount4.ToString());


            //is greater than D
            int charCount5 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'D')
                {
                    charCount5++;
                }
            }

            Console.WriteLine(charCount5.ToString());


            //is less than 9
            int charCount6 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '9')
                {
                    charCount6++;
                }
            }

            Console.WriteLine(charCount6.ToString());

            //is greater than 1
            int charCount7 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > '1')
                {
                    charCount7++;
                }
            }

            Console.WriteLine(charCount7.ToString());


            //is greater than g and less than m
            int charCount8 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'g' && str[i] < 'm')
                {
                    charCount8++;
                }
            }

            Console.WriteLine(charCount8.ToString());



            //is greater than G and less than M
            int charCount9 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'G' && str[i] < 'M')
                {
                    charCount9++;
                }
            }

            Console.WriteLine(charCount9.ToString());



            //is greater than G and less than m
            int charCount10 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'G' && str[i] < 'm')
                {
                    charCount10++;
                }
            }

            Console.WriteLine(charCount10.ToString());



            //is greater than g and less than M
            int charCount11 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'g' && str[i] < 'M')
                {
                    charCount11++;
                }
            }

            Console.WriteLine(charCount11.ToString());



            //is less than a and greater than 6
            int charCount12 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'a' && str[i] > '6')
                {
                    charCount12++;
                }
            }

            Console.WriteLine(charCount12.ToString());



            //is greater than a and not equal to B
            int charCount13 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 'a' && str[i] != 'B')
                {
                    charCount13++;
                }
            }

            Console.WriteLine(charCount13.ToString());




            //is less than z and greater than x
            int charCount14 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'z' && str[i] > 'x')
                {
                    charCount14++;
                }
            }

            Console.WriteLine(charCount14.ToString());





            //is greater than 1 or less than b
            int charCount15 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > '1' && str[i] < 'b')
                {
                    charCount15++;
                }
            }

            Console.WriteLine(charCount15.ToString());





            //is less than z and greater than A
            int charCount16 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'z' && str[i] > 'A')
                {
                    charCount16++;
                }
            }

            Console.WriteLine(charCount16.ToString());




            //is greater than or equal to a AND less than or equal to z
            int charCount17 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    charCount17++;
                }
            }

            Console.WriteLine(charCount17.ToString());



            //is greater than or equal to A AND less than or equal to Z
            int charCount18 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    charCount18++;
                }
            }

            Console.WriteLine(charCount18.ToString());


            //is greater than or equal to 0 AND less than or equal to 9
            int charCount19 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    charCount19++;
                }
            }

            Console.WriteLine(charCount19.ToString());









            for (int sndx = 0; sndx <= str.Length; sndx++)
            {
                char cChar = str2[sndx];

                if (sndx %3==0 && sndx!=0 && sndx %2 == 0 )
                {
                   
                    strOut += char.ToLower(cChar);
                  

                }

                else
                {

                    strOut += char.ToUpper(cChar);
                }

                MessageBox.Show(strOut);




            }

        }

    }   
}
