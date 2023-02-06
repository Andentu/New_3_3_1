namespace New_3_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = new string(Console.ReadLine());
            Console.WriteLine("Сколько вам лет?");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Есть ли у вас питомец? (Да/Нет)");
            string IHavePet = new string(Console.ReadLine());
            bool HavePet;
            if (IHavePet == "Да")
            {
                HavePet= true;
            }
            else { HavePet = false; }
            Console.WriteLine("Какой у вас размер ноги?");
            float Lsize = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Do you have a pet? " + HavePet);
            Console.WriteLine("Your shoe size is " + Lsize);

            Console.ReadKey();
        }
    }
}