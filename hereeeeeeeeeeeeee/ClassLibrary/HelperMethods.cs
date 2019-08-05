using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace ClassLibrary
{
    public class HelperMethods
    {

        public static void TypeWriter(string message) 
        {
            for (int i = 0; i < message.Length; i++)
            {
                Write(message[i]);
                System.Threading.Thread.Sleep(20);
            }
        }

        public static void ChangeColor()
        {
            BackgroundColor = ConsoleColor.DarkMagenta;
            Clear();
            ForegroundColor = ConsoleColor.Cyan;
            Clear();
        }
    }
}
