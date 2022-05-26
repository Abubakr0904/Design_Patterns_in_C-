namespace SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }

        public void Action()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}