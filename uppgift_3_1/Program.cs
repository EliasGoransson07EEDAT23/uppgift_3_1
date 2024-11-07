using System;
namespace uppgift_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, om du vill vara med i Gymnasietävlingen 2024 så måste du verifiera din ålder. Skriv ålder i siffror nedan.");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Verifierar ålder... ");
            
            if (age <= 19 && age >= 16)
            {
                Console.WriteLine("Okej, du är " + age + " år gammal, vilket är mellan åldersgränsen.");
                Console.WriteLine("Detta betyder att du är kvalificerad till att tävla i Gymnasietävlingen 2024!");
            }

            else if (age < 16)
            {
                Console.WriteLine("Okej, du är " + age + " år gammal, vilket är under åldersgränsen (16-19 år).");
                Console.WriteLine("Detta betyder att du inte är kvalificerad för Gymnasietävlingen 2024. Du är för ung.");
            }

            else if (age > 19)
            {
                Console.WriteLine("Okej, du är " + age + " år gammal, vilket är över åldersgränsen (16-19 år).");
                Console.WriteLine("Detta betyder att du inte är kvalificerad för Gymnasietävlingen 2024. Du är för gammal.");
            }

            else
            {
                Console.WriteLine("Va??? Nåt är väldigt konstigt här, hit ska man inte kunna komma!!! :'(");
            }
            Console.ReadKey(); 

        }
    }
}