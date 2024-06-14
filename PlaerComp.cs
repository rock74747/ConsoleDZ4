using Playr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playr
{
    public class PlaerComp
    {
        public static void Main2(string[] args)
        {
            int n = 0;
            int currentPlayer = 0;
            bool currentfield;
            Random r = new Random();
            int number = r.Next(1,2);
             Play.field[0] = '1';
             Play.field[1] = '2';
             Play.field[2] = '3';
             Play.field[3] = '4';
             Play.field[4] = '5';
             Play.field[5] = '6';
             Play.field[6] = '7';
             Play.field[7] = '8';
             Play.field[8] = '9';
            do
            {
                Console.Clear();
                Play.FieldFunc();
                if (number == 2)
                {
                    currentPlayer = 2;
                    Console.WriteLine($"Игрок, введите номер ячейки:");
                    currentfield = int.TryParse(Console.ReadLine(), out n);
                }
                if (number == 1)
                {
                    currentPlayer = 1;
                    Random s = new Random();
                    n = s.Next(1, 9);
                    currentfield = true;
                }
                currentfield = true && n >= 1 && n <= 9 && Play.field[n - 1] != 'X' && Play.field[n - 1] != 'O';

                if (currentfield)      // Заполняем ячейку 
                {

                    Play.field[n - 1] = (currentPlayer == 1) ? 'X' : 'O';

                    // Проверка на выигрыш
                    if (Play.WinningFunc())
                    {
                        Console.Clear();
                        Play.FieldFunc();
                        if (currentPlayer == 2)
                        {
                            Console.WriteLine($"Победил игрок");
                        }
                        else
                            Console.WriteLine($"Победил компьютер");
                        break;
                    }

                    // Проверка на ничью
                    if (Play.DrawFunc())
                    {
                        Console.Clear();
                        Play.FieldFunc();
                        Console.WriteLine(" Сегодня ничья");
                        break;
                    }

                    // Смена 
                    number = (number == 1) ? 2 : 1;
                }
                else
                    Console.WriteLine("Неправильный ввод. Повтор хода.");

            } while (true);
        }

    }
}

