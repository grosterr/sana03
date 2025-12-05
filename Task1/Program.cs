using System.Text;
using System;
public class MyArray {
    public static double Negative_sum(double[] arr, int N)
    {
        double neg = 0.0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] < 0)
            {
                neg += arr[i];
            }
        }
        return neg;
    }
    public static double Min(double[] arr, int N)
    {
        double min = 20.0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    public static int Max_Index(double[] arr, int N)
    {
        int index = 0; double max = -20.0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                index = i;
            }
        }
        return index;
    }
    public static double Max_Abs(double[] arr, int N)
    {
        double max = 0.0;
        for (int i = 0; i < N; i++)
        {
            if (Math.Abs(arr[i]) > max)
            {
                max = Math.Abs(arr[i]);
            }
        }
        return max;
    }
    public static int Index_sum_pos(double[] arr, int N)
    {
        int sum_ind = 0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] > 0)
            {
                sum_ind += i;
            }
        }
        return sum_ind;
    }
    public static int Integer_check(double[] arr, int N)
    {
        int integ = 0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] % 1 == 0)
            {
                integ += 1;
            }
        }
        return integ;
    }
    public static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        int N;
        double minV = -10.0;
        double maxV = 10.0;
        double range = maxV - minV;
        Random random = new Random();
        Console.WriteLine("Введіть кількість елементів масиву: "); N = int.Parse(Console.ReadLine());
        double[] arr = new double[N];
        Console.WriteLine($"Масив розміром[{N}]: ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = random.NextDouble() * range + minV;
            Console.WriteLine($"{arr[i]} ");
        }
        double sumneg = Negative_sum(arr, N);
        Console.WriteLine($"Сума від'ємних чисел = {sumneg}");
        double min = Min(arr, N);
        Console.WriteLine($"Мінімальний елемент масиву = {min}");
        double max_ind = Max_Index(arr, N);
        Console.WriteLine($"Індекс максимального елементу = {max_ind}");
        double max_abs = Max_Abs(arr, N);
        Console.WriteLine($"Максимальне за модулем число = {max_abs}");
        int sum_p = Index_sum_pos(arr, N);
        Console.WriteLine($"Сума індексів додатніх елементів = {sum_p}");
        int integ = Integer_check(arr, N);
        Console.WriteLine($"В масиві цілих чисел: {integ}");
    }
}