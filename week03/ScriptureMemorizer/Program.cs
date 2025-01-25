using System;
using System.Reflection.Metadata.Ecma335;
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
            private Reference _reference;
            private List<Word> _words;

            public Scripture (Reference reference, string text)
            {
                _reference = reference;
                _words = new List<Word>();

                string[] wordArray = text.Split( ' ');
                foreach (string word in wordArray)
                {
                    _words.Add(new Word(word));
                }
            }

            public void HideRandomeWords(int numberToHide)
            {
                Random random = new Random();
                int hiddenCount = 0;

                while (hiddenCount < numberToHide)
                {
                    int index = random.Next(_words.Count);
                    if (! _words[index].IsHidden())
                    {
                        _words[index].Hide();
                        hiddenCount++;
                    }
                }
            }

            public string GetDisplayText()
            {
                string displayText = _reference.GetDisplayText() + " ";
                foreach (Word word in _words)
                {
                    displayText += word.GetDisplayText() + " ";
                }

                return displayText.Trim();

            }

            public bool IsCompleatlyHidden()
            {
                foreach (Word word in _words)
                {
                    if (!word.IsHidden())
                    {
                        return false;
                    }
                }
                return true;
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

            public Reference(string book, int chapter, int verse)
            {
                _book = book;
                _chapter = chapter;
                _startVerse = verse;
                _endVerse = -1;
            }

            public Reference(string book, int chapter, int verse) //creative addition for user's own scripture upload.
            {
                _book = book;
                _chapter = chapter;
                _startVerse = verse;
                _endVerse = endVerse;
            }

            public string GetDisplayText()
            {
                if (_endVerse == 1)
                {
                    return $"{_book} {_chapter}:{_startVerse}";
                }
                else
                {
                    return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
                }
            }



        }


    }

}