namespace GB_CS_OOP
{
    public class Mammal : Animal, Walking
    {
        public Mammal (string name, int age) : base(name, age) {
        }

        public void Walk()
        {
            System.Console.WriteLine(this.name + " is walking");
        }
    }
}