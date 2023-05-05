namespace GB_CS_OOP
{
    public class Animal : Breathing
    {
        public string name;
        public int age;
        public Animal(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public void Info() {
            System.Console.WriteLine("Name - " + this.name + ". Age - " + this.age);
        }

        public void Breathe() {
            System.Console.WriteLine(this.name + " is breathing");
        }
    }
}