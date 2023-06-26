namespace homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(0, 1), new Point(2, 3), new Point(3, 0)));
            triangles.Add(new Triangle(new Point(0, 5), new Point(4, 3), new Point(3, 8)));
            triangles.Add(new Triangle(new Point(1, 1), new Point(2, 7), new Point(3, 3)));

            foreach (Triangle triangle in triangles)
            {
                triangle.Print();
            }
            Console.WriteLine("Triangle with vertex closest to origin is:");
            triangles.MinBy(Triangle => Triangle.DistanceToOrigin()).Print();
        }
    }
}