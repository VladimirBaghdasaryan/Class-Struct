namespace Class___Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1=new Book("Raffi","Samvel",400);
            book1.Print();

            Rectangle rectangle1 = new Rectangle(10, 25);
            rectangle1.RectangleSquare();

            Score score1 = new Score(123456789, 10000);
            score1.Deposit(1000);
            score1.GetBalance();
            score1.Withdraw(2000);
            score1.GetBalance();

            Car bmw = new Car("BMW", "X6", 2023);
            bmw.DisplayInfo();

            Point point1 = new Point(2, 5);
            Point point2 = new Point(10, 3);

            point1.Display();
            point2.Display();
        }
    }
}