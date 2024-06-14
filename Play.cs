using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playr
{
    public class Play
    {
       public static char[] field = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
       public static int currentPlayer = 1; // 1 - крестики, 2 - нолики   


        public static void FieldFunc() // отрисовка поля в консоли
        {
            Console.WriteLine($" {field[0]} | {field[1]} | {field[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {field[3]} | {field[4]} | {field[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {field[6]} | {field[7]} |  {field[8]} ");
        }

        public static bool WinningFunc() // Кто выиграл
        {
            return (field[0] == field[1] && field[1] == field[2]) ||
                (field[3] == field[4] && field[4] == field[5]) ||
                (field[6] == field[7] && field[7] == field[8]) ||
                (field[0] == field[3] && field[3] == field[6]) ||
                (field[1] == field[4] && field[4] == field[7]) ||
                (field[2] == field[5] && field[5] == field[8]) ||
                (field[0] == field[4] && field[4] == field[8]) ||
                (field[2] == field[4] && field[4] == field[6]);
        }


        public static bool DrawFunc() // Проверка на ничью
        {
            foreach (char field in Play.field)
            {
                if (field != 'X' && field != 'O')
                    return false;
            }
            return true;
        }
    }
    
}
