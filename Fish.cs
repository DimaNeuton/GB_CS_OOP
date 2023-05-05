namespace GB_CS_OOP
{
    public class Fish : Animal, Swimming
    {
        public Fish(string name, int age) : base(name, age) {
        }

        public void Swim()
        {
            System.Console.WriteLine(this.name + " is swimming");
        }
    }
}