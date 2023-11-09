double r = double.Parse(Console.ReadLine());

Console.WriteLine("Area = " + Math.PI * r * r);
Console.WriteLine("Perimetre = " + 2 * Math.PI * r);



int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int area = a * b;
int paramentre = 2 * area;
Console.WriteLine($"Area is: {area}");
Console.WriteLine($"Paramentre is: {paramentre}");



double x1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double width = Math.Max(x1, x2) - Math.Min(x2, x1);
double height = Math.Max(y1, y2) - Math.Min(y1, y2);
Console.WriteLine("Area = " + width * height);
Console.WriteLine("Perimeter = " + 2 *(width + height));