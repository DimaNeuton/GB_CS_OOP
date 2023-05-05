namespace GB_CS_OOP
{
    public class Bird : Animal, Flying
    {

        public Bird(string name, int age) : base(name, age) {
        }

        public void Fly()
        {
            System.Console.WriteLine(this.name + " is flying");
        }
    }
}