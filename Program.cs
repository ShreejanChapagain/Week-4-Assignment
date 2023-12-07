class Program
{
    public static void Main(String[] args)
    {
        BankAccount account = new BankAccount("191991x");
        Car car = new Car("dadada", 1900, 1000f);
        account.Display();
        car.Display();
        Rectangle rectangle = new Rectangle(500, 800);
        rectangle.Display();
        Circle circle = new Circle();
        Console.WriteLine($"Area is {circle.CalculateArea(2)}");
        Student student = new Student("Tate", 36, "Money");
        student.Introduce();
        Stack<int> stack = new Stack<int>();
        Console.WriteLine(stack.isEmpty());
        stack.Push(10);
        stack.Push(20);
        Console.WriteLine(stack.isEmpty());
        stack.getItems();
        Calender calender = new Calender();
        calender.PrintWeekDays();
        Point2D p1 = new Point2D(5f, 7f);
        Point2D p2 = new Point2D(7f, 3f);
        AnotherClassThatUsesPoint2D ac = new AnotherClassThatUsesPoint2D();
        ac.CalculateDistance(p1, p2);
    }
}