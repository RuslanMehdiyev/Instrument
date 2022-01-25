using System;

namespace instruments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Симфонию");
            IInstriment[] instruments = { new Guitar(), new Drum(), new Trumpet()};
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i].Play();
            }
            Console.Read();
        }
    }
    interface IInstriment
    {
        static string Key = "До мажор";
        public void Play();
    }
    class Guitar : IInstriment
    {
        public static byte String { get { return 6; } }
        public void Play()
        {
            Console.WriteLine($"Играет гитара с {String} струнами.");
        }
    }
    class Drum : IInstriment
    {
        public static byte Size { get { return 10; } }
        public void Play()
        {
            Console.WriteLine($"Играет барабан с размером {Size}");
        }
    }
    class Trumpet : IInstriment
    {
        public static byte Diameter { get { return 5; } }
        public void Play()
        {
            Console.WriteLine($"Играет труба с диаметром {Diameter}");
        }
    }
}