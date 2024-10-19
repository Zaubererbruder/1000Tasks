namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.Animals.Add(new Animal("Kangaroo", 10));
            Animal Begemoth = new Animal("Begemoth", 1);
            zoo.Animals.Add(Begemoth);
            zoo.Animals.Remove(Begemoth);
            zoo.Animals.Add(new Animal("Mr Sea Lion", 20));

            foreach(Animal a in zoo.Animals)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
