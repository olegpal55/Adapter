

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("\nthe turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nthe duck says...");
            TestDuck(duck);

            Console.WriteLine("\nthee turkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}