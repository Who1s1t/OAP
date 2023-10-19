//стр 36 № 1(б)
//Console.WriteLine("e =");
//double e = Convert.ToDouble(Console.ReadLine());
//double sum = 0;
//while (true)
//{
//    double tmp = Convert.ToDouble(Console.ReadLine());
//    tmp = (1 / Math.Pow(2, tmp) + 1 / Math.Pow(3, tmp));
//    if (Math.Abs(tmp) >= e)
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





//стр 33 №3
//Console.WriteLine("N =");
//int N = Convert.ToInt32(Console.ReadLine());
//double P = 1;
//for (double i = 1; i <= N; i++)
//{
//    P *= (2 * i) / (2 * i + 1);

//}
//Console.WriteLine($"Произвдение = {P}");






//стр 41 №1
//Console.WriteLine("n =");
//int n = Convert.ToInt32(Console.ReadLine());
//int g = n;
//while (n > 9)
//{
//    n /= 10;
//}
//Console.WriteLine($"Сумма певрой и последней цифры равна {g % 10 + n}");





//стр 43 №1
//Console.WriteLine("n = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int flag = 0;
//while (n != 0)
//{
//    int tmp = n % 10;
//    int tmpn = n /10;

//    while (tmpn != 0)
//    {
//        if (tmpn%10 == tmp)
//        {
//            flag = 1;
//            break;
//        }
//        tmpn /=10;
//    }

//    if (flag == 1) {
//        break;
//    }

//    n /= 10;


//}

//if (flag == 1)
//{
//    Console.WriteLine("Цифры повторяются!");
//}
//else
//{
//    Console.WriteLine("Цифры не повторяются!");
//}



// стр 38 № 1
//int sum = 0;

//while (true)
//{
//    sum += Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Сумма = {sum}");




// стр 38 № 4
//int count = 0;
//Console.WriteLine("Введите число для подсчёта");
//int x = Convert.ToInt32(Console.ReadLine());
//while (true)
//{
//    int tmp = Convert.ToInt32(Console.ReadLine());
//    if (tmp == x) {
//    count++;
//    }
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Кол-во  {count}");




// стр 38 № 6
//int composition = 1;

//while (true)
//{
//    composition *= Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Произведение = {composition}");




// стр 38 № 7
//int sum = 0;

//while (true)
//{
//    sum += Math.Abs(Convert.ToInt32(Console.ReadLine()));
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Сумма модулей = {sum}");





//стр 38 № 9
//double sum = 0;

//while (true)
//{
//    sum += Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Сумма квадратов = {sum}");




// стр 38 № 10
//int sum = 0;
//int count = 0;
//while (true)
//{
//    sum += Convert.ToInt32(Console.ReadLine());
//    count++;
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Cредне арфмитическое = {Convert.ToDouble( sum )/ Convert.ToDouble(count)}");



// стр 38 № 12
//int composition = 1;

//while (true)
//{
//    composition *= Math.Abs(Convert.ToInt32(Console.ReadLine()));
//    Console.WriteLine("Продольжить последовательность? Y/N");
//    if (Console.ReadLine() == "N")
//    {
//        break;
//    }

//}
//Console.WriteLine($"Произведение = {composition}");