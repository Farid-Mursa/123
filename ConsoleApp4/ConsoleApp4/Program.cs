namespace ConsoleApp4
{
    public class MathHelper
    {
        public int PrintValue(int a,int b)
        {
            return a + b;
        }
        public int PrintValue(bool a)
        {
            return a ? 1 : 0;
        }
        public void PrintValue(string a,string b)
        {
            Console.WriteLine(a+" "+b);
        }
        public int PrintValue(int a, int b,int c)
        {
            return a * b * c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();
            Console.WriteLine(mathHelper.PrintValue(5,6));
            Console.WriteLine(mathHelper.PrintValue(false));
            mathHelper.PrintValue("Salam", "Aleykum");
            Console.WriteLine(mathHelper.PrintValue(5,6,7));
            
        }
    }
}