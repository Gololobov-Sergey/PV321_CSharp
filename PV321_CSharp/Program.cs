
using System.Text;
using System.Threading.Channels;

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Title = "PV321";
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
Console.Clear();


DateTime date = DateTime.Now;
Console.WriteLine(date.ToLongDateString());
Console.WriteLine(date.ToLongTimeString());
Console.WriteLine(date.ToShortDateString());
Console.WriteLine(date);
DateTime dd = DateTime.Parse(Console.ReadLine());
Console.WriteLine(dd.DayOfWeek);

//string s = Console.ReadLine();  
//Console.WriteLine(s);

//int? a = Convert.ToInt32(Console.ReadLine());

//int b = Int32.Parse(Console.ReadLine());

//int c;
//Int32.TryParse(Console.ReadLine(), out c);

//Console.WriteLine(100M);

//Console.WriteLine($"slkdjf iferi {a} kwjh ewjei {b} skdjfo ewifuwoei");

//Console.WriteLine(2 << 3);

//string? st = null;
//int? dd = null;
//dd = dd ?? 50;

int a = 10;
if (a == 56)
{
    Console.WriteLine("10");
}
else
{

}


switch (a)
{
    case 2:
        Console.WriteLine("a");
        break;
    case 3:
    case 4:
    default:
        break;
}


int res = a switch
{
    1 => 10,
    2 => 10,
    3 => 10,
    _ => 5
};

int c = a > 10 ? 10 : 5;


int[] arr = new int[10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    arr[i] = rand.Next(10);
}

foreach (int i in arr)
{
    //i *= 2;
    Console.Write(i + " ");
}



Console.WriteLine();

Console.SetCursorPosition(10, 10);
Console.WriteLine("Hello, World!");

Console.Read();
