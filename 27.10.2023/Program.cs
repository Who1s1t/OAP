//стр. 21 № 20
//Console.WriteLine("Введите a");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите b");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите c");
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите m");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите n");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n == a * Math.Pow(m, 2) + b * m + c)
//{
//    Console.WriteLine("Проходит");
//}
//else
//{
//    Console.WriteLine("НЕ проходит");
//}



//стр. 21 № 25
//Console.WriteLine("Введите ширину первого параллелепипеда");
//int x1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите длину первого параллелепипеда");
//int y1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите высоту первого параллелепипеда");
//int z1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите ширину второго параллелепипеда");
//int x2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите длину второго параллелепипеда");
//int y2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите высоту второго параллелепипеда");
//int z2 = Convert.ToInt32(Console.ReadLine());

//if  (x1 * y1 * z1 > x2 *y2 * z2)
//{
//    Console.WriteLine("Первый больше");
//} else if (x1 * y1 * z1 < x2 * y2 *z2)
//{
//    Console.WriteLine("Второй больше");
//}
//else
//{
//    Console.WriteLine("Параллелепипеды равны");
//}



//стр. 34  № 4
//Console.WriteLine("N=");
//int N = Convert.ToInt32(Console.ReadLine());

//double cos = 0, sin = 0, res = 1;

//for (int i = 1;  i <= N; i++)
//{
//    cos += Math.Cos(i);
//    sin += Math.Sin(i);
//    res *= cos/ sin;
//}
//Console.WriteLine(res);


//стр. 34  № 11
//double res = 1;

//for (double i = 0.1; i <= 10; i += 0.1)
//{
//    res *= 1 + Math.Sin(i);
//}
//Console.WriteLine(res);


//стр. 39  № 22
//Console.WriteLine("Введите цифру");
//double e = Convert.ToDouble(Console.ReadLine());
//double sum = 0;
//while (true)
//{
//    int tmp = Convert.ToInt32(Console.ReadLine());
 
//    if (tmp % 10 == e)
//    {
//        sum += tmp;
//    }
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }
//}
//Console.WriteLine(sum);