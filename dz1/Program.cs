namespace dz1Otus_Home_Work_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число от 1 до 6");
            int tableSize;
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
            int inputLength;
            bool textNotVoid=false;
            text = Console.ReadLine();
            inputLength = text.Length;
            tableSize = (numberValue - 1) * 2 + inputLength + 2;
            for (int i = 0; i < 4; i++)
            {
                Border(tableSize);
                switch (i)
                {
                    case 0:
                        FirstCell(inputLength, textNotVoid, numberValue, tableSize, text);
                        break;
                    case 1:
                        CenterCell(tableSize, numberValue);
                        break;
                    case 2:
                        LastCell(tableSize, numberValue); 
                        break;
                }
            }
        }
        static void FirstCell(int inputLength, bool textNotVoid, int numberValue, int tableSize, string text)
        {
            do
            {
                textNotVoid = !String.IsNullOrWhiteSpace(text) && text.Length < 41;
                if (!textNotVoid)
                    Console.WriteLine("Туть пусто");
            }
            while (textNotVoid == false);
            for (int counter1 = 1; counter1 < numberValue; counter1++)
                Console.WriteLine("+".PadRight(tableSize - 1, ' ') + ('+'));
            Console.WriteLine("+".PadRight(numberValue, ' ') + text + "+".PadLeft(numberValue, ' '));
            for (int counter2 = 1; counter2 < numberValue; counter2++)
                Console.WriteLine("+".PadRight(tableSize - 1, ' ') + ('+'));
            string border = new string('+', tableSize);
        }
        static void Border(int tableSize)
        {
            string border = new string('+', tableSize);
            Console.WriteLine(border);
        }
        static void CenterCell(int tableSize, int numberValue)
        {
            int height = (numberValue - 1) * 2 + 1;
            for (int plus = 0; plus < height; plus++)
            {
                string kto_kuda = null;
                for (int space = 0; space < tableSize - 1; space++)
                {
                    kto_kuda += ((plus + space) % 2 == 0) ? "+" : " ";
                    int firtPosition = 0;
                    char replacement = '+';
                    kto_kuda = (kto_kuda.Remove(firtPosition, 1).Insert(firtPosition, replacement.ToString()));
                }
                Console.WriteLine(kto_kuda + "+");
            }
        }
        static void LastCell(int tableSize, int numberValue)
        {
            string cross = null;
            string centerSpaсe;
            string left_rightSpace;
            int quantityCenterSpaсe = tableSize - 4;
            int quantityLeftRightSpace = 0;

            for (int counter = 0; counter < tableSize - 1; counter++)
            {
                string lenghtCenterSpaсe = new string(' ', quantityCenterSpaсe);
                string lenghtLeftRightSpace = new string(' ', quantityLeftRightSpace);
                if (tableSize % 2 == 0 && counter < (tableSize - 2) / 2 - 1)
                {
                    for (int counter1 = (tableSize - 2) / 2; counter1 >= 0; counter1--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenghtCenterSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quantityCenterSpaсe -= 2;
                        quantityLeftRightSpace += 1;
                        break;
                    }
                }
                else if (tableSize % 2 == 0 && quantityCenterSpaсe == 0 && counter < (tableSize - 2) / 2)
                {
                    cross = "+" + lenghtLeftRightSpace + "+" + lenghtCenterSpaсe + "+" + lenghtLeftRightSpace + "+";
                    Console.WriteLine(cross);
                } 
                if (tableSize % 2 == 0 && counter > (tableSize - 2) / 2)
                {
                    for (int counter2 = (tableSize - 2) / 2; counter2 >= 0; counter2--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenghtCenterSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quantityCenterSpaсe += 2;
                        quantityLeftRightSpace -= 1;
                        break;
                    }
                }
                if (tableSize % 2 == 1 && counter < (tableSize - 3) / 2 - 1)
                {
                    for (int counter3 = (tableSize - 3) / 2; counter3 >= 0; counter3--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenghtCenterSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quantityCenterSpaсe -= 2;
                        quantityLeftRightSpace += 1;
                        break;
                    }
                }
                else if (tableSize % 2 == 1 && counter == (tableSize - 3) / 2 + 1)
                {
                    cross = "+ " + lenghtLeftRightSpace + "+" + lenghtLeftRightSpace + " +";
                    Console.WriteLine(cross);
                }
                else if (tableSize % 2 == 1 && counter == (tableSize - 3) / 2)
                {
                    cross = "+" + lenghtLeftRightSpace + "+" + lenghtCenterSpaсe + "+" + lenghtLeftRightSpace + "+";
                    Console.WriteLine(cross);
                }
                if (tableSize % 2 == 1 && counter > (tableSize - 3) / 2 + 1)
                {
                    for (int counter4 = (tableSize - 3) / 2; counter4 >= 0; counter4--)
                    {
                        cross = "+" + lenghtLeftRightSpace + "+" + lenghtCenterSpaсe + "+" + lenghtLeftRightSpace + "+";
                        Console.WriteLine(cross);
                        quantityCenterSpaсe += 2;
                        quantityLeftRightSpace -= 1;
                        break;
                    }
                }
            }
        }
    }
}














