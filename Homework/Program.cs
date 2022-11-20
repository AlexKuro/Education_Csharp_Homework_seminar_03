
void Task_19()
{
    /*Задача 19

        Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            14212 -> нет
            23432 -> да
            12821 -> да*/

    Console.WriteLine("               ------Задача 19-------");
    Console.WriteLine("     Напишите программу, которая принимает на вход ");
    Console.WriteLine("пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine();
    Console.Write("Введите пятизначное число:-> ");

    int container = Convert.ToInt32(Console.ReadLine());
    int number = Math.Abs(container);
    int[] arrayNumber = new int[7];
    int count = 4;

    if (number > 9999 && number < 100000)
    {
        while (number > 10)
        {   
            arrayNumber[count] = number % 10;
            number /= 10;
            count = count - 1;
        }
    arrayNumber[count] = number;

        if (arrayNumber[0] == arrayNumber[4] && arrayNumber[1] == arrayNumber[3]) Console.WriteLine($"     Число {container} -> ПАЛИНДРОМ"); 
        else Console.WriteLine($"   Число {container} -> НЕ ПАЛИНДРОМ"); 

    } 
    else 
    {
        Console.WriteLine("    Неправильный ввод данных!!!");       
    }
    Console.WriteLine();     
}

void Task_21()
{
    /*Задача 21

        Напишите программу, которая принимает на вход координаты двух точек 
        и находит расстояние между ними в 3D пространстве.

        A (3,6,8); B (2,1,-7), -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53*/

    Console.WriteLine("               ------Задача 21-------");
    Console.WriteLine("  Напишите программу, которая принимает на вход координаты");
    Console.WriteLine("двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine();
    Console.Write("Введите координаты x, y, z точки А через пробел :-> ");
    string point_A = Console.ReadLine();

    Console.Write("Введите координаты x, y, z точки B через пробел :-> ");
    string point_B = Console.ReadLine();

    string[] pointSplit_A = point_A.Split(); 
    string[] pointSplit_B = point_B.Split();

    Console.Write($"      A ({pointSplit_A[0]}, {pointSplit_A[1]}, {pointSplit_A[2]}); ");
    Console.Write($" B ({pointSplit_B[0]}, {pointSplit_B[1]}, {pointSplit_B[2]}); ");
    Console.Write($" -> {DistancePointXyZ(pointSplit_A, pointSplit_B)}"); 
    Console.WriteLine();
    Console.WriteLine();    
}

double DistancePointXyZ (string[] A, string[] B) // формула вычисления расстояния между двумя точками в 3D пространстве 
{
    double result = Math.Sqrt(Math.Pow(Convert.ToInt32(B[0]) - Convert.ToInt32(A[0]), 2) + Math.Pow(Convert.ToInt32(B[1]) - Convert.ToInt32(A[1]), 2) + Math.Pow(Convert.ToInt32(B[2]) - Convert.ToInt32(A[2]), 2)); 
    return Math.Round(result, 2);
}

void Task_23()
{
    /*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        3 -> 1, 8, 27
        5 -> 1, 8, 27, 64, 125*/

    Console.WriteLine("               ------Задача 23-------");
    Console.WriteLine("Напишите программу, которая принимает на вход число (N)");
    Console.WriteLine("       и выдаёт таблицу кубов чисел от 1 до N");
    Console.WriteLine();
    Console.Write("Введите число:-> ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;

    if (number > 0)
    {
        while (count <= number)
        {
        Console.WriteLine($"   {count} * {count} * {count} = {Math.Pow(count, 3)} ");
        count++;
        }
    }
    else 
    {
        Console.WriteLine("    Неправильный ввод данных!!!");       
    }   
    Console.WriteLine();   
}

Task_19(); 
Task_21(); 
Task_23(); 
