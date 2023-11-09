double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double area = width * height / 2;
Console.WriteLine(Math.Round(area, 2));


double celcee = double.Parse(Console.ReadLine());

double ferinheight = (celcee * 9 / 5) + 32;
Console.WriteLine(Math.Round(ferinheight, 2));

double rad = double.Parse(Console.ReadLine());
double deg = rad * (180 / Math.PI);
Console.WriteLine(Math.Round(deg, 2));





double money = double.Parse(Console.ReadLine());
string valuta = Console.ReadLine();

if (valuta == "USD")
{
    money = 1.79549;
}
else if (valuta == "EUR")
{
    money = 1.95583;
}
else if (valuta == "GBP")
{
    money = 2.53405;
}
else if (valuta == "BGN")
{
    money = 1;
}
Console.WriteLine(Math.Round(money, 2));