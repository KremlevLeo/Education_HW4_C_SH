namespace HT4;

class Program
{
    static void Main(string[] args)
    {
        MainManu();
    }
    private static bool MainManu()
    {
        Console.Clear();
        Console.WriteLine("1) Degree;");
        Console.WriteLine("2) Amount;");
        Console.WriteLine("3) Array;");
        Console.WriteLine("4) Exit.");
        Console.Write("\nSelect: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Enter a degree: ");
                int deg = int.Parse(Console.ReadLine());
                int res = Degree(num, deg);
                Console.WriteLine($"\n{num}, {deg} -> {res}");
                return true;
            case "2":
                Console.Clear();
                Console.Write("Enter are number: ");
                string str = Console.ReadLine();
                int[] numarr = str.Select(x => int.Parse(x.ToString())).ToArray();
                res = Amoun(numarr);
                Console.WriteLine($"\n {str} -> {res}");
                return true;
            case "3":
                Console.Clear();
                Console.Write("Enter the length of the array: ");
                int leng = int.Parse(Console.ReadLine());
                int[] resArr = FillArr(leng);
                PrintArr(resArr);
                return true;
            case "4":
                return false;
            default:
                return false;
        }
    }
    /// <summary>
    /// Возведение в степень.
    /// </summary>
    /// <param name="a">Число</param>
    /// <param name="b">Степень</param>
    /// <returns>Чилсло возведенное в степень</returns>
    private static int Degree(int a, int b)
    {
        int tmp = a;
        for (int i = 2; i <= b; i++)
        {
            tmp *= a;
        }
        return tmp;
    }
    /// <summary>
    /// Сложение всех числе массива
    /// </summary>
    /// <param name="arr">Массив для сложения</param>
    /// <returns>Сумму всех чисел</returns>
    private static int Amoun(int[] arr)
    {
        int tmp = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            tmp += arr[i + 1];
        }
        return tmp;
    }
    /// <summary>
    /// Вывод массива в консоль
    /// </summary>
    /// <param name="arrMy">Массив для вывода</param>
    private static void PrintArr(int[] arrMy)
    {
        Console.Write("[");
        for (int i = 0; i < arrMy.Length; i++)
        {
            if (i < arrMy.Length - 1)
                Console.Write($"{arrMy[i]}, ");
            else
                Console.Write($"{arrMy[i]}]");
        }
    }
    /// <summary>
    /// Заполняет массив случайными числами от 1 до 100
    /// </summary>
    /// <param name="numb">Длинна массива</param>
    /// <returns></returns>
    private static int[] FillArr(int numb)
    {
        var rand = new Random();
        int[] resArr = new int[numb];
        for (int i = 0; i < resArr.Length; i++)
        {
            resArr[i] = rand.Next(0, 101);
        }
        return resArr;
    }

}
