namespace FabricPriclad
{
    interface ILang
    {
        void Display();
    }
    class L1 : ILang
    {
        public void Display()
        {
            Console.WriteLine("Мова програмування C#");
        }
    }
    class L2 : ILang
    {
        public void Display()
        {
            Console.WriteLine("Мова програмування Python");
        }
    }
    class L3 : ILang
    {
        public void Display()
        {
            Console.WriteLine("Мова програмування Java");
        }
    }
    interface IFactory
    {
        ILang CreateLang();
    }
    class L1Factory : IFactory
    {
        public ILang CreateLang()
        {
            return new L1();
        }
    }
    class L2Factory : IFactory
    {
        public ILang CreateLang()
        {
            return new L2();
        }
    }
    class L3Factory : IFactory
    {
        public ILang CreateLang()
        {
            return new L3();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число 1,2 або 3: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    IFactory factory = new L1Factory();
                    ILang lang = factory.CreateLang();
                    lang.Display();
                    break;
                case 2:
                    IFactory factory2 = new L2Factory();
                    ILang lang2 = factory2.CreateLang();
                    lang2.Display(); break;
                case 3:
                    IFactory factory3 = new L3Factory();
                    ILang lang3 = factory3.CreateLang();
                    lang3.Display(); break;
                default: Console.WriteLine("Ni"); break;
            }
        }
    }
}
