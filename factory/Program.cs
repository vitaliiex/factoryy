namespace Fabric
{

    public abstract class Acer
    {
        public abstract void OS();
    }

    public abstract class Lenovo
    {
        public abstract void OS();
    }
    public class AWin : Acer
    {
        public override void OS()
        {
            Console.WriteLine("Acer має операційну систему Windows.");
        }
    }

    public class LWin : Lenovo
    {
        public override void OS()
        {
            Console.WriteLine("Lenovo має операційну систему Windows.");
        }
    }
    public abstract class OSFactory
    {
        public abstract Acer CreateAcer();
        public abstract Lenovo CreateLenovo();
    }

    public class WindowsOsFactory : OSFactory
    {
        public override Acer CreateAcer()
        {
            return new AWin();
        }

        public override Lenovo CreateLenovo()
        {
            return new LWin();
        }
    }

    public class LinuxOsFactory : OSFactory
    {
        public override Acer CreateAcer()
        {
            return new ALin();
        }

        public override Lenovo CreateLenovo()
        {
            return new LLin();
        }
    }
    public class ALin : Acer
    {
        public override void OS()
        {
            Console.WriteLine("Acer має операційну систему Linux.");
        }
    }

    public class LLin : Lenovo
    {
        public override void OS()
        {
            Console.WriteLine("Lenovo має операційну систему Linux.");
        }
    }
    class User
    {
        public void CreateOS(OSFactory factory)
        {
            var acer = factory.CreateAcer();
            var lenovo = factory.CreateLenovo();

            acer.OS();
            lenovo.OS();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WindowsOsFactory WF = new WindowsOsFactory();
            LinuxOsFactory LF = new LinuxOsFactory();

            User client = new User();

            Console.WriteLine("Операційна система Windows : ");
            client.CreateOS(WF);

            Console.WriteLine("Операційна система Linux : ");
            client.CreateOS(LF);
        }
    }
}
