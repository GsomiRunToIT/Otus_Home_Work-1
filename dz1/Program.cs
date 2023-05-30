
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
            int razmerTAbl;
            bool sravnit;
            string text;
            do
            {
                var schitat = Console.ReadLine();
                sravnit = Int32.TryParse(schitat, out razmerTAbl) && (razmerTAbl >= 1) && (razmerTAbl <= 6);
                if (!sravnit)
                    Console.WriteLine("Неккоректное чило,введите число от 1 до 6 ");
            }
            while (sravnit == false);
            int wirinaVsego;
            int dlinaVvoda;
            bool Text_NE_Pustoi;
            do
            {
                text = Console.ReadLine();
                dlinaVvoda = text.Length;
                Text_NE_Pustoi = !String.IsNullOrWhiteSpace(text) && text.Length < 41;
                if (!Text_NE_Pustoi)
                    Console.WriteLine("Туть пусто");
            }
            while (Text_NE_Pustoi == false);
            Console.WriteLine("CONGRATILACION");
            Console.Clear();
            wirinaVsego = (razmerTAbl - 1) * 2 + dlinaVvoda + 2;
            string granici = new string('+', wirinaVsego);
            Console.WriteLine(granici);
            for (int s4et4ik_strok1 = 1; s4et4ik_strok1 < razmerTAbl; s4et4ik_strok1++)
                Console.WriteLine("+".PadRight(wirinaVsego - 1, ' ') + ('+'));
            Console.WriteLine("+".PadRight(razmerTAbl, ' ') + text + "+".PadLeft(razmerTAbl, ' '));
            for (int s4et4ik_strok1 = 1; s4et4ik_strok1 < razmerTAbl; s4et4ik_strok1++)
                Console.WriteLine("+".PadRight(wirinaVsego - 1, ' ') + ('+'));
            Console.WriteLine(granici);

            int visota = (razmerTAbl - 1) * 2 + 1;
            for (int plus = 0; plus < visota; plus++)
            {
                string kto_kuda = null;
                for (int probel = 0; probel < wirinaVsego - 1; probel++)
                {
                    kto_kuda += ((plus + probel) % 2 == 0) ? "+" : " ";
                    int firtPosition = 0;
                    //int lastPosition = wirinaVsego-1 ;
                    char zamena = '+';
                    kto_kuda = (kto_kuda.Remove(firtPosition, 1).Insert(firtPosition, zamena.ToString()));
                    //kto_kuda = (kto_kuda.Remove(lastPosition, 1).Insert(lastPosition, zamena.ToString()));
                }
                Console.WriteLine(kto_kuda + "+");//костыль
            }
            Console.WriteLine(granici);

            string cross = null;
            string centerSpaсe;
            string left_rightSpace;

            int quentityCenterSpase = wirinaVsego - 4;
            int quentityLeft_rightSpace = 0;


            for (int counter = 0; counter < wirinaVsego - 1; counter++)
            {
                string lenght_centerSpaсe = new string(' ', quentityCenterSpase);
                string lenght_left_rightSpace = new string(' ', quentityLeft_rightSpace);
                //чёт
                if (wirinaVsego % 2 == 0 && counter < (wirinaVsego - 2) / 2 - 1)
                {
                    for (int counter1 = (wirinaVsego - 2) / 2; counter1 >= 0; counter1--)
                    {
                        cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase -= 2;
                        quentityLeft_rightSpace += 1;
                        break;
                    }
                }
                else if (wirinaVsego % 2 == 0 && quentityCenterSpase == 0 && counter < (wirinaVsego - 2) / 2)
                {
                    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
                    Console.WriteLine(cross);
                }

                if (wirinaVsego % 2 == 0 && counter > (wirinaVsego - 2) / 2)
                {
                    for (int counter2 = (wirinaVsego - 2) / 2; counter2 >= 0; counter2--)
                    {
                        cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase += 2;
                        quentityLeft_rightSpace -= 1;
                        break;
                    }
                }
                // нечёт -----------------------------------------------------------------------------------------
                

                if (wirinaVsego % 2 == 1 && counter < (wirinaVsego - 2) / 2 - 1)
                {
                    for (int counter3 = (wirinaVsego - 2) / 2; counter3 >= 0; counter3--)
                    {
                        cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase -= 2;
                        quentityLeft_rightSpace += 1;
                        break;
                    }
                }

                else if (wirinaVsego % 2 == 1 && quentityCenterSpase == 1 && counter == (wirinaVsego - 2) / 2 + 1)
                {
                   
                    cross = "+" + lenght_left_rightSpace + "+" + lenght_left_rightSpace + "+";
                    Console.WriteLine(cross);
                    

                }
                else if (wirinaVsego % 2 == 1 && (counter == (wirinaVsego - 3) / 2))
                {
                   // quentityLeft_rightSpace = (wirinaVsego - 3) / 2;
                    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
                    Console.WriteLine(cross);
                }
                //else if (wirinaVsego % 2 == 1 && counter == (wirinaVsego  - 3 ) / 2 + 1 )
                //{
                //  quentityLeft_rightSpace  +=1 ;
                //}

                if (wirinaVsego % 2 == 1 && counter > (wirinaVsego - 3) / 2 )
                {
                    
                    for (int counter4 = (wirinaVsego - 3) / 2; counter4 >= 0; counter4--)
                    {
                        cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
                        Console.WriteLine(cross);
                        quentityCenterSpase += 2;
                        quentityLeft_rightSpace -= 1;
                        break;
                    }
                }


            }
        }
    }
}





//krestikniz = "+" + poprobelu3 + "+" + poprobelu4 + "+" + poprobelu3 + "+";

//while (poprobelu4.Length == 0)
//char pomigaika = '+';
//int skolkoPlusov = krestikverh.Count(f => (f == pomigaika));
//Console.WriteLine(krestikniz);


//if (counter % 2 == 0 && counter == (wirinaVsego) / 2 + 1)
//{
//    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
//    Console.WriteLine(cross);

//}



//if (counter < (wirinaVsego - 2) / 2 - 1)
//{
//    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";

//    Console.WriteLine(cross);
//    quentityCenterSpase -= 2;
//    quentityLeft_rightSpace += 1;
//}
//if (counter == (wirinaVsego - 2) / 2 && counter % 2 == 1) //vot tut
//{


//    cross = "+" + lenght_left_rightSpace + "+" + lenght_left_rightSpace + "+";
//    Console.WriteLine(cross);


//    //quentityCenterSpase -= 2;
//    //quentityLeft_rightSpace += 1;

//    // cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";





//    // quentityCenterSpase += 2;
//    // quentityLeft_rightSpace -= 1;

//}

//if (counter % 2 == 0 && counter == (wirinaVsego) / 2 + 1)
//{
//    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
//    Console.WriteLine(cross);

//}

//if (counter > (wirinaVsego - 2) / 2 + 1 && quentityLeft_rightSpace >= 0)
//{

//    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
//    quentityCenterSpase += 2;
//    quentityLeft_rightSpace -= 1;
//    Console.WriteLine(cross);
//}







//string krestik = null;
//string zamena2 = "+";
//int positionplus = 1; positionplus++;
//int plusposition = wirinaVsego - 1; plusposition--;
//for (int kvo_strok = wirinaVsego; kvo_strok > 0; kvo_strok--)
//    Console.Write(krestik);


//(dubikat_probel2 = 0; dubikat_probel2 < (wirinaVsego / 2); dubikat_probel2--)

// 
//







//    krestik = ((krestik.Remove(positionPlus, 1).Insert(positionPlus, zamena2.ToString())));
// Console.WriteLine(granici);




//ширина таблицы не должна превышать 40 символов
//Границы таблицы - символ +
//Ширина таблицы (каждой строки) зависит от числа n и длины введенной строки
//Вывести 1ю ячейку таблицы с текстом, введенным в п.2., который находится на расстоянии n-1 от каждой из границ строки.
//Вывести 2ю ячейку таблицы. Она имеет ту же высоту, что и ячейка 1, и представляет собой набор символов +, чередующихся в шахматном порядке.
//Вывести 3ю ячейку таблицы. Она должна быть квадратной, "перечеркнутая" символом + по диагоналям
// В программе должны использоваться циклы do while, while и for и ?:





//for (int counter = 0; counter <= wirinaVsego - 2; ++counter)
//{
//    cross = "+" + new string(' ', quentityLeft_rightSpace) + "+" + new string(' ', quentityCenterSpase) + "+" + new string(' ', quentityLeft_rightSpace) + "+";
//    Console.WriteLine(cross);

//    if (counter < (wirinaVsego - 2) / 2-1)
//    {
//        quentityCenterSpase -= 2;
//        quentityLeft_rightSpace += 1;
//    }
//    else if (counter == (wirinaVsego - 2) / 2-1  && counter % 2 == 1)

//    {
//        //cross = "+" + new string(' ', quentityLeft_rightSpace) + "+" + new string(' ', quentityLeft_rightSpace) + "+";
//        quentityCenterSpase -= 2;
//        quentityLeft_rightSpace += 1;
//    }
//    else if (counter == (wirinaVsego - 2) / 2 - 1 )

//    {
//        //quentityCenterSpase -= 2;
//        //quentityLeft_rightSpace += 1;
//    }

//    else
//    {
//        quentityCenterSpase += 2;
//        quentityLeft_rightSpace -= 1;
//    }

//}
//if (counter == (wirinaVsego) / 2 + 1 && counter % 2 == 1 && quentityCenterSpase == 1) //vot tut
//{


//    cross = "+" + lenght_left_rightSpace + "+" + lenght_left_rightSpace + "+";
//    Console.WriteLine(cross);


//    quentityCenterSpase -= 2;
//    quentityLeft_rightSpace += 1;

//    // cross = "+" + lenght_left_rightspace + "+" + lenght_centerspaсe + "+" + lenght_left_rightspace + "+";





//    // quentitycenterspase += 2;
//    // quentityleft_rightspace -= 1;

//}

//else
//{
//    cross = "+" + lenght_left_rightSpace + "+" + lenght_centerSpaсe + "+" + lenght_left_rightSpace + "+";
//    if (counter <= (wirinaVsego - 2) / 2 - 1)
//    {
//        quentityCenterSpase -= 2;
//        quentityLeft_rightSpace += 1;


//        Console.WriteLine(cross);
//    }

//    else if (counter == (wirinaVsego - 2) / 2 - 1 && wirinaVsego % 2 == 1)
//    {
//        quentityCenterSpase -= 2;
//        quentityLeft_rightSpace += 1;
//    }
//    if (counter % 2 == 0 && counter == (wirinaVsego) / 2 + 1)
//    {

//        Console.WriteLine(cross);

//    }
//    if (counter > (wirinaVsego - 2) / 2 + 1 && quentityLeft_rightSpace >= 0)
//    {
//        quentityCenterSpase += 2;
//        quentityLeft_rightSpace -= 1;
//        Console.WriteLine(cross);
//    }



//}