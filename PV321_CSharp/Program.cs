
using System.Net;
using System.Text;
using System.Threading.Channels;
using PV321_CSharp;

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Title = "PV321";
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
Console.Clear();

///// 21.12.2023  ////////
///

Student st = new Student 
{ 
    FirstName = "Oleg", 
    LastName = "Petrov", 
    StudentCardNumber = "AB 123432", 
    BirthDay = new DateTime(2000, 12, 5) 
};
Student st1 = new Student
{
    FirstName = "Tatyana",
    LastName = "Osipova",
    StudentCardNumber = "AC 123432",
    BirthDay = new DateTime(2001, 10, 15)
};

Student st2 = new Student();

st.Print();
st1.Print();
st2.Print();

//Point p = new Point(3, 6);
//p.Print();

//Console.WriteLine(Stud.id);
//Stud student = new Stud();
//Stud.group = 55;
//student.marks[0] = 5;

//student.Number = 1;
//int s = student.Number;
//student.Name = "Serg";

//void func(ref int[] arr, ref int a, out int b)
//{
//    arr = new int[5] { 66, 66, 66, 66, 66 };
//    //arr[0] = 100;
//    a = 100;
//    b = 1000;
//}


//int[] arr = { 1, 2, 3, 4 };
//int a = 5;
//int b;

//func(ref arr, ref a, out b);

//Console.WriteLine(arr[0]);
//Console.WriteLine(a);
//Console.WriteLine(b);

//int Summ(int a, params int[] arr)
//{
//    int res = 0;
//    foreach (int i in arr)
//    {
//        res += i;
//    }
//    return res;
//}

//Console.WriteLine(Summ(1,2,3,4));
//Console.WriteLine(Summ(1,2,3,4,3));
//Console.WriteLine(Summ(1,2,3,4,4,5,6));


// 1 1 2 3 5 8 13 21 34 55 ....


///// 20.12.2023  ////////
///

bool elemBig10(int a)
{
    return a > 10;
}

//int[] arr1 = new int[10];
//int[] arr2 = new int[10] { 1,2,3,4,5,6,7,8,9,10};
//Console.WriteLine(arr2.Length);
//int[] arr3 = { 441,2,13,34,45,6,7,8,9,10};
//int[] arr4;
//arr4 = { 1,2,3,4,5,6,7,8,9,10};
//arr3[2] = 999;
//Console.WriteLine(arr3[2]);
//Console.WriteLine(arr3.GetLength(0));
//Array.Sort(arr3);
//Console.WriteLine(arr3);
//foreach(int i in arr3)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//int [] arr7 = Array.FindAll(arr3, elemBig10);
//foreach (int i in arr7)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//Створіть додаток, який відображає кількість значень у
//масиві менше заданого параметра користувачем. Наприклад,
//кількість значень менших, ніж 7 (7 введено користувачем
//з клавіатури).

//int[] arr = new int[10];
//Random rand = new Random();
//for (int i = 0; i < 10; i++)
//{
//    arr[i] = rand.Next(10);
//}
//foreach (int i in arr)
//{
//    Console.Write(i + " ");
//}

//int val = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//foreach (int elem in arr)
//{
//    if (elem < val)
//        count++;
//}
//Console.WriteLine(count);



//int[,] arr = new int[,] { { 3,4,5},{3,2,4 },{5,3,3 } };
//int[,] arr22 = { { 3,4,5},{3,2,4 },{5,3,3 } };

//Console.WriteLine(arr[1,2]);
//Console.WriteLine(arr22.Length);
//for (int i = 0; i < arr22.GetLength(0); i++)
//{
//    for (int j = 0; j < arr22.GetLength(1); j++)
//    {
//        Console.Write($"{arr22[i,j]} ");
//    }
//    Console.WriteLine();
//}


//int[][] arr33 = new int[3][];
//arr33[0] = new int[] { 2, 5, 8, 9, 4 };
//arr33[1] = new int[] { 2, 8, 4 };
//arr33[2] = new int[] { 2, 8, 9, 4 };

//for (int i = 0; i < arr33.Length; i++)
//{
//    for (int j = 0; j < arr33[i].Length; j++)
//    {
//        Console.Write($"{arr33[i][j]} ");
//    }
//    Console.WriteLine();
//}


//string st = "mama";
//Console.WriteLine(st.EndsWith("ma1"));
//Console.WriteLine(st.PadLeft(10) + " papa");
//Console.WriteLine(st.PadRight(10) + " papa");
//Console.WriteLine(st[2]);
//string st1 = st + "ewdwe";
//st1 += "eieie";

//StringBuilder sb = new StringBuilder();
//sb.Append(st1);
//sb.AppendLine(st1);
//string gg = sb.ToString();  
//Console.WriteLine(gg);



//string st = Console.ReadLine();
//int count = st.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
//Console.WriteLine(count);


//int? a = Convert.ToInt32(Console.ReadLine());
//int m = 0;
//while (a > 0)
//{
//    int r = (int)a % 10;
//    m = m * 10 + r;
//    a /= 10;
//}
//Console.WriteLine(m);


//DateTime date = DateTime.Now;
//Console.WriteLine(date.ToLongDateString());
//Console.WriteLine(date.ToLongTimeString());
//Console.WriteLine(date.ToShortDateString());
//Console.WriteLine(date);
//DateTime dd = DateTime.Parse(Console.ReadLine());
//Console.WriteLine(dd.DayOfWeek);

//string s = Console.ReadLine();  
//Console.WriteLine(s);

//int? a = Convert.ToInt32(Console.ReadLine());

//int b = Int32.Parse(Console.ReadLine());

//int c = 8;
//Int32.TryParse(Console.ReadLine(), out c);

//Console.WriteLine(100M);

//Console.WriteLine($"slkdjf iferi {a} kwjh ewjei {b} skdjfo ewifuwoei");

//Console.WriteLine(2 << 3);

//string? st = null;
//int? dd = null;
//dd = dd ?? 50;

//int a = 10;
//if (a == 56)
//{
//    Console.WriteLine("10");
//}
//else
//{

//}


//switch (a)
//{
//    case 2:
//        Console.WriteLine("a");
//        break;
//    case 3:
//    case 4:
//    default:
//        break;
//}


//int res = a switch
//{
//    1 => 10,
//    2 => 10,
//    3 => 10,
//    _ => 5
//};

//int c = a > 10 ? 10 : 5;


//int[] arr = new int[10];
//Random rand = new Random();
//for (int i = 0; i < 10; i++)
//{
//    arr[i] = rand.Next(10);
//}

//foreach (int i in arr)
//{
//    //i *= 2;
//    Console.Write(i + " ");
//}



//Console.WriteLine();

//Console.SetCursorPosition(10, 10);
//Console.WriteLine("Hello, World!");

Console.Read();
