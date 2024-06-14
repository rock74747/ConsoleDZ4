﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    public class Morzesimbol
    {
        private string[,] dictionary_ = new string[,]
           {{"А", ".-"}, {"Б", "-..."}, {"В", ".--"}, {"Г", "--."},
            {"Д", "-.."}, {"Е", "."}, {"Ё", "."}, {"Ж", "...-"}, {"З", "--.."},
            {"И", ".."}, {"Й", ".---"}, {"К", "-.-"}, {"Л", ".-.."},
            {"М", "--"}, {"Н", "-."}, {"О", "---"}, {"П", ".--."},
            {"Р", ".-."}, {"С", "..."}, {"Т", "-"}, {"У", "..-"},
            {"Ф", "..-."}, {"Х", "...."}, {"Ц", "-.-."}, {"Ч", "---."},
            {"Ш", "----"}, {"Щ", "--.-"}, {"Ъ", "--.--"}, {"Ы", "-.--"},
            {"Ь", "-..-"}, {"Э", "..-.."}, {"Ю", "..--"}, {"Я", ".-.-"},
            {".", "......"}, {",", ".-.-.-"}, {":", "---..."}, {";", "-.-.-."},
            {"(", "-.--.-"}, {"\\", ".-..-."}, {"-", "-....-"}, {"?", "..--.."},
            {"!", "--..--"}, {"+", ".-.-."}, {"1", ".----"}, {"2", "..---"},
            {"3", "...--"}, {"4", "....-"}, {"5", "....."}, {"6", "-...."},
            {"7", "--..."}, {"8", "---.."}, {"9", "----."}, {"0", "-----"}};
        public string Translate(string sym) // Метод перевода символа в строку кода азбуки Морзе
        {
            string str = "2";
            if (sym == " ")
                return str;
            for (int i = 0; i < dictionary_.GetLength(0); ++i)
                if (dictionary_[i, 0] == sym)
                    str = dictionary_[i, 1] + "1";
            return str;
        }
        public char Translate_Back(string str) // Метод перевод строки кода азбуки Морзе в символ
        {
            char sym = ' ';
            for (int i = 0; i < dictionary_.GetLength(0); ++i)
                if (str == dictionary_[i, 1])
                    sym = Convert.ToChar(dictionary_[i, 0].ToLower());
            return sym;
        }

        public static void Main3(string[] args)
        {
            Console.Write("Введите текст на русском языке -> ");
            string str = Console.ReadLine().ToUpper();
            string result = "";
            Morzesimbol m = new Morzesimbol();
            foreach (char el in str)
                result += m.Translate(Convert.ToString(el));
            Console.WriteLine("\nВведённый текст на азбуке Морзе:\n" + result + "\n\nОбратный перевод в русский язык:\n");
            str = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1' || result[i] == '2')
                {
                    str += m.Translate_Back(result.Substring(0, i));
                    if (result[i] == '2' && i != 0)
                        str += ' ';
                    result = result.Remove(0, i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(str);

        }
    }
    
}
