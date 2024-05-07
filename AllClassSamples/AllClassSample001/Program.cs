using AllClassSample001;

static void Main(string[] args)
{
    MyShape rect = new MyRectangle() { Width = 10, Height = 10};
    Console.WriteLine($"方形的面積是 {rect.GetArea()}");
    MyShape circle = new MyCircle() { Radius = 3};
    Console.WriteLine($"圓形的面積是 {circle.GetArea()}");
    Console.ReadLine();
}