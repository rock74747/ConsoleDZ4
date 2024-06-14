using Playr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Playr
{
    public class PlaerPlayr
    {
        public static void Main1(string[] args)
        {
            int n;
            bool currentfield;

            do
            {
                Console.Clear();
                Play.FieldFunc();
                Console.WriteLine($"Игрок {Play.currentPlayer}, введите номер ячейки:");

                // Проверяем корректность ввода
                currentfield = int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 9 && Play.field[n - 1] != 'X' && Play.field[n - 1] != 'O';

                if (currentfield)      // Заполняем ячейку 
                {

                    Play.field[n - 1] = (Play.currentPlayer == 1) ? 'X' : 'O';

                    // Проверка на выигрыш
                    if (Play.WinningFunc())
                    {
                        Console.Clear();
                        Play.FieldFunc();
                        Console.WriteLine($"Победил игрок под номером {Play.currentPlayer}");
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

                    // Смена игрока
                    Play.currentPlayer = (Play.currentPlayer == 1) ? 2 : 1;
                }
                else
                    Console.WriteLine("Неправильный ввод. Повтор хода.");

            } while (true);
        }
    }
            


 }

