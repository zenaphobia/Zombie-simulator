using System;
using System.Threading;
namespace ZombieSimulator
{
    public class Animation
    {
        public void animateText(string _text)
        {
            if(_text.Length < 1)
            {
                Console.WriteLine("Error, please input text for animation");
            }
            foreach(char letter in _text)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            //Line break;
            Console.WriteLine("");
        }

        public void pause()
        {
            Console.WriteLine("");
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine("");
        }
    }
}