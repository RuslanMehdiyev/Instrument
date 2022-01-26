using System;

namespace instruments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Филармонию\n");
            Guitar guitar = new();
            Drum drum = new();
            Trumpet trumpet = new();
            Console.Write("Введите количество струн гитары:");
            guitar.Strings = Validation.ValidationGuitar();
            Console.Write("Введите размер барабана:");
            drum.Sizes = Validation.ValidationDrum();
            Console.Write("Введите диаметр трубы:");
            trumpet.Diameters = Validation.ValidationTrumpet();
            IInstriment[] instruments = { guitar, drum, trumpet };
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
        private byte String;
        public byte Strings
        {
            set
            {
                String = value;
            }
            get
            {
                return String;
            }
        }
        public void Play()
        {
            Console.WriteLine($"Играет гитара с {String} струнами:{IInstriment.Key}");
        }
    }
    class Drum : IInstriment
    {
        private byte Size;
        public byte Sizes
        {
            set
            {
                Size = value;
            }
            get
            {
                return Size;
            }
        }
        public void Play()
        {
            Console.WriteLine($"Играет барабан с размером {Size}:{IInstriment.Key}");
        }
    }
    class Trumpet : IInstriment
    {
        private byte Diameter;
        public byte Diameters
        {
            set
            {
                Diameter = value;
            }
            get
            {
                return Diameter;
            }
        }
        public void Play()
        {
            Console.WriteLine($"Играет труба с диаметром {Diameter}мм:{IInstriment.Key}");
        }
    }
    static class Validation
    {
        public static byte ValidationGuitar()
        {
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out byte value) && value > 3 && value < 13)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("\nМин количество струн гитары составляет 4,Макс. 12. Введите правильное количество:\n");
                }
            }
        }
        public static byte ValidationDrum()
        {
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out byte value) && value > 4 && value < 26)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("\nМин размер барабана составляет 5,Макс. 25. Введите правильный размер:\n");
                }
            }
        }
        public static byte ValidationTrumpet()
        {
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out byte value) && value > 21 && value < 81)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("\nМин диметр трубы составляет 20мм,Макс. 80мм. Введите правильный диаметр:\n");
                }
            }
        }
    }
}