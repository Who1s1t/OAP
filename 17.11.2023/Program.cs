//Уроки 20-21

//№4
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//if (x > 0)
//    {
//    if (y > 0)
//    {
//        Console.WriteLine("1");
//    }else{
//        Console.WriteLine("4");
//    }

//}else{
//    if ( y > 0)
//    {
//        Console.WriteLine("2");
//    }else{
//        Console.WriteLine("3");
//    }
//}




//№5
//string[] arr = Console.ReadLine().Split();
//int x = int.Parse(arr[0]);
//int y = int.Parse(arr[1]);
//int z = int.Parse(arr[2]);
//if (x > 0)
//{
//    if (y > 0)
//    {
//        if (z > 0)
//        {
//            Console.WriteLine('1');
//        }else { 
//            Console.WriteLine("5"); 
//        }
//    }
//    else
//    {
//        if (z > 0)
//        {
//            Console.WriteLine('4');
//        }
//        else
//        {
//            Console.WriteLine("8");
//        }
//    }
//}
//else
//{
//    if (y > 0)
//    {
//        if (z > 0)
//        {
//            Console.WriteLine('2');
//        }
//        else
//        {
//            Console.WriteLine("6");
//        }
//    }
//    else
//    {
//        if (z > 0)
//        {
//            Console.WriteLine('3');
//        }
//        else
//        {
//            Console.WriteLine("7");
//        }
//    }
//}




//Уроки 22-23



//№3
//string[] arr = Console.ReadLine().Split();
//int x = int.Parse(arr[0]);
//int y = int.Parse(arr[1]);
//int z = int.Parse(arr[2]);
//int tmp = 0;
//if (x> y)
//{
//    tmp = x;
//    x = y;
//    y = tmp;
//    if (y > z)
//    {
//        tmp = z;
//        z = y;
//        y = tmp;
//        if (x > y)
//        {
//            tmp = x;
//            x = y;
//            y = tmp;
//        }
//    }
//}
//else
//{
//    if (y > z)
//    {
//        tmp = z;
//        z = y;
//        y = tmp;
//        if (x > y)
//        {
//            tmp = x;
//            x = y;
//            y = tmp;
//        }
//    }

//  }

//Console.WriteLine($"{x} {y} {z}");



//№4
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Math.Abs(x - x1);
int y2 = Math.Abs(y - y1);
if (x2 == 2 && y2 == 1 || x2 == 1 && y2 == 2)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}