using System;

//тестовое задание
//функция должна печатать  на экран числа от единицы до ста.
//Но, если число кратно 3, вместо него должно быть напечатано слово Zenno, 
//если кратно пяти — слово Poster. 
//А если оно кратно 15-ти, то должно быть напечатано слово ZennoPoster
namespace test
{
    class Program
    {
        /// <summary>
        /// функция печатает числа от 1 до 100. Если число кратно 3, будет напечатано слово Zenno, если число кратно 5 - слово Poster, если число кратно 15, ZennoPoster
        /// </summary>
        static void PrintNumber()
        {
            for (byte i = 1; i <= 100; i++) //
            {
                if (i % 15 == 0) //если число кратно 15
                {
                    Console.WriteLine("ZennoPoster"); //напечатать ZennoPoster
                    continue;
                }

                if (i % 5 == 0) //если число кратно 5
                {
                    Console.WriteLine("Poster"); //напечатать Poster
                    continue;
                }

                if (i % 3 == 0) //если число кратно 3
                {
                    Console.WriteLine("Zenno"); //напечатать Zenno
                    continue;
                }

                Console.WriteLine(i); //напечатать i

            }
        }

        static void Main(string[] args)
        {
            PrintNumber();
            Console.ReadKey();
        }
    }
}
