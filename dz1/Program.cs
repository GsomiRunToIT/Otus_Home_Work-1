
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

namespace dz1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число от 1 до 6");
            int numberValue;
            bool textNotNumber;
            string text;
            do
            {
                var userString = Console.ReadLine();
                textNotNumber = Int32.TryParse(userString, out numberValue) && (numberValue >= 1) && (numberValue <= 6);
                if (!textNotNumber)
                    Console.WriteLine("Неккоректное чило,введите число от 1 до 6 ");
            }
            while (textNotNumber == false);
            int tableSize;
            int inputLength;
            bool textNotVoid;
            do
            {
                text = Console.ReadLine();
                inputLength = text.Length;
                textNotVoid = !String.IsNullOrWhiteSpace(text) && text.Length < 41;
                if (!textNotVoid)
                    Console.WriteLine("Туть пусто");
            }
            while (textNotVoid == false);
            Console.WriteLine("CONGRATILACION");
            Console.Clear();
            tableSize = (numberValue - 1) * 2 + inputLength + 2;
            string border = new string('+', tableSize);
            Console.WriteLine(border);
            for (int counter1 = 1; counter1 < numberValue; counter1++)
                Console.WriteLine("+".PadRight(tableSize - 1, ' ') + ('+'));
            Console.WriteLine("+".PadRight(numberValue, ' ') + text + "+".PadLeft(numberValue, ' '));
            for (int counter2 = 1; counter2 < numberValue; counter2++)
                Console.WriteLine("+".PadRight(tableSize - 1, ' ') + ('+'));
            Console.WriteLine(border);

            int height = (numberValue - 1) * 2 + 1;
            for (int plus = 0; plus < height; plus++)
            {
                string kto_kuda = null;
                for (int spase = 0; spase < tableSize - 1; spase++)
                {
                    kto_kuda += ((plus + spase) % 2 == 0) ? "+" : " ";
                    int firtPosition = 0;
                    //int lastPosition = tableSize-1 ;
                    char replacement = '+';
                    kto_kuda = (kto_kuda.Remove(firtPosition, 1).Insert(firtPosition, replacement.ToString()));
                    //kto_kuda = (kto_kuda.Remove(lastPosition, 1).Insert(lastPosition, replacement.ToString()));
                }
                Console.WriteLine(kto_kuda + "+");//костыль
            }
            Console.WriteLine(border);

            string cross = null;
            string centerSpaсe;
            string left_rightSpace;

            int quentityCenterSpase = tableSize - 4;
            int quentityLeftRightSpace = 0;


            for (int counter = 0; counter < tableSize - 1; counter++)
            {
                string lenght_centerSpaсe = new string(' ', quentityCenterSpase);
                string lenghtLeftRightSpace = new string(' ', quentityLeftRightSpace);
                //чёт
                if (tableSize % 2 == 0 && counter < (tableSize - 2) / 2 - 1)
                {
                    for (int counter1 = (tableSize - 2) / 2; counter1 >= 0; counter1--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase -= 2;
                        quentityLeftRightSpace += 1;
                        break;
                    }
                }
                else if (tableSize % 2 == 0 && quentityCenterSpase == 0 && counter < (tableSize - 2) / 2)
                {
                    cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                    Console.WriteLine(cross);
                }
                // нечёт -----------------------------------------------------------------------------------------
                

                if (tableSize % 2 == 0 && counter > (tableSize - 2) / 2)
                {
                    for (int counter2 = (tableSize - 2) / 2; counter2 >= 0; counter2--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase += 2;
                        quentityLeftRightSpace -= 1;
                        break;
                    }
                }
                // нечёт -----------------------------------------------------------------------------------------


                if (tableSize % 2 == 1 && counter < (tableSize - 3) / 2 - 1)
                {
                    for (int counter3 = (tableSize - 2) / 2; counter3 >= 0; counter3--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase -= 2;
                        quentityLeftRightSpace += 1;
                        break;
                    }
                }
                

                else if (tableSize % 2 == 1 && quentityCenterSpase == 1 && counter == (tableSize - 2) / 2 )
                {
                   
                    cross = "+" + lenghtLeftRightSpace + "+" + lenghtLeftRightSpace + "+";
                    Console.WriteLine(cross);
                    

                }
                else if (tableSize % 2 == 1 && counter == (tableSize - 3) / 2-1 )
                {
                   // quentityLeftRightSpace = (tableSize - 3) / 2;
                    cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                    Console.WriteLine(cross);
                }
                //else if (tableSize % 2 == 1 && counter1 == (tableSize  - 3 ) / 2 + 1 )
                //{
                //  quentityLeftRightSpace  +=1 ;
                //}

                if (tableSize % 2 == 1 && counter > (tableSize - 3) / 2+1 )
                {
                    
                    for (int counter4 = (tableSize - 3) / 2; counter4 >= 0; counter4--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase += 2;
                        quentityLeftRightSpace -= 1;
                        break;
                    }
                }
               
                if (tableSize % 2 == 1 && counter > (tableSize - 3) / 2 )
                {
                    
                    for (int counter4 = (tableSize - 3) / 2; counter4 >= 0; counter4--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenght_centerSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase += 2;
                        quentityLeftRightSpace -= 1;
                        break;
                    }
                }


            }
        }
    }
}















