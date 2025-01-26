using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ScriptureMemorizer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

            Console.WriteLine("Choose a scripture youd like to memorise:");//This is my creative addition
            Console.WriteLine(" ");
            Console.WriteLine("1. Mark 12:30-31");
            Console.WriteLine("2. Luke 6:27-28");
            Console.WriteLine("3. Matthew 7:1-3");
            Console.WriteLine("4. John 8:7");

            string choice = Console.ReadLine();
            Scripture selectedScripture= null;

            if (choice == "1")//This is my creative addition
            {
                Reference reference =new Reference ("Mark 12:30-31",12,30,31);
                selectedScripture = new Scripture (reference,"And thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind, and with all thy strength: this is the first commandment. And the second is like, namely this, Thou shalt love thy neighbour as thyself. There is none other commandment greater than these.");
            }
            else if (choice == "2")//This is my creative addition
            {
                Reference reference =new Reference ("Luke 6:27-28",6,27,28);
                selectedScripture = new Scripture (reference,"But I say unto you which hear, Love your enemies, do good to them which hate you, Bless them that curse you, and pray for them which despitefully use you. ");
            }
            else if (choice == "3")//This is my creative addition
            {
                Reference reference =new Reference ("Matthew 7:1-3",7,1,3);
                selectedScripture = new Scripture (reference,"Judge not, that ye be not judged. For with what judgment ye judge, ye shall be judged: and with what measure ye mete, it shall be measured to you again. And why beholdest thou the mote that is in thy brother's eye, but considerest not the beam that is in thine own eye? ");
            }
            else if (choice == "4")//This is my creative addition
            {
                Reference reference =new Reference ("John 8:7",8,7);
                selectedScripture = new Scripture (reference,"So when they continued asking him, he lifted up himself, and said unto them, He that is without sin among you, let him first cast a stone at her.");
            }
            if (selectedScripture == null)
            {
                Console.WriteLine("Invalid choice. Try running again.");
                return;
            }


            while (true)
            {
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish. To upload a different scripture type 'upload': ");
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    Console.Clear();
                    break;
                }
            
                Console.Clear();
                selectedScripture.HideRandomWords(3);

                if (selectedScripture.IsCompleatlyHidden())
                {
                    Console.WriteLine(selectedScripture.GetDisplayText());
                    break;
                }
            }
        }


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
            public void HideRandomWords(int numberToHide)
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
                string displayText = " ";
                foreach (Word word in _words)
                {
                    displayText += word.GetDisplayText() + " ";
                }

                return _reference.GetDisplayText() + " " + displayText.Trim();

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



        public class Word
        {
            private string _text;
            private bool _isHidden;

            public Word (string text)
            {
                _text = text;
                _isHidden = false;
            }
            public void Hide()
            {
                _isHidden = true;
            }
            public void Show()
            {
                _isHidden = false;
            }
            public bool IsHidden()
            {
                return _isHidden;
            }
            public string GetDisplayText()
            {
                if (_isHidden)
                {
                    return new string('_', _text.Length);
                }
                return _text;
            } 
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
            public Reference(string book, int chapter, int startVerse, int endVerse) 
            {
                _book = book;
                _chapter = chapter;
                _startVerse = startVerse;
                _endVerse = endVerse;
            }
            public string GetDisplayText()
            {
                if (_endVerse == -1)
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
