using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference =new Reference ("Mark 12:30-31",3,5,6);
        Scripture scripture = new Scripture ("And thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind, and with all thy strength: this is the first commandment. And the second is like, namely this, Thou shalt love thy neighbour as thyself. There is none other commandment greater than these.")

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");


            string input = Console.ReadLine();


            if (input == "quit")
            {
                Console.Clear();
                Console.WriteLine("");
                break;
            }
        }

        Console.Clear();

        public class Scripture
        {
            private string _text;
            private bool _hiddenWord;

            public Word (string text)
            {
                _text = text;
                _hiddenWord = false;
            }

            public void Hide()
            {
                _hiddenWord = true;
            }

            public void HiddenWord()
            {
                _hiddenWord = false;
            }


        }



        public class World
        {

        }


        public class Reference
        {
            private string _book;
            private int _chapter;
            private int _startVerse;
            private int _endVerse;
        }


    }

}