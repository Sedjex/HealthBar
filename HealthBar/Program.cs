using System;

namespace HealthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int healht = 10, maxHealth = 20;
            int mana = 3, maxMana = 20;

            while (true)
            {

                DrawBar(healht, maxHealth, ConsoleColor.DarkGreen, 0, '_');
                DrawBar(mana, maxMana, ConsoleColor.Yellow, 2, '_');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введіть число на яке змінити життя: ");
                healht += Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть число на яке змінити ману: ");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }

        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = ' ')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }

            Console.Write(bar + ']');

        }
    }
}
