namespace GB_CS_OOP
{
    class Program {
        static void Main(string[] args) {
            Animal a1 = new Animal("cat", 10);
            a1.Info();
            Bird b1 = new Bird("sparrow", 2);
            b1.Info();
            Fish f1 = new Fish("trout", 3);
            Mammal m1 = new ("bear", 7);

            b1.Fly();
            f1.Swim();
            m1.Walk();
        }
    }
}