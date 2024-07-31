using System.Runtime.Serialization;

class Program
{
    public static void Main()
    {
        Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
        Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
        Console.WriteLine(Min(new[] { '4', '2', '7' }));
    }



    static IComparable Min(Array args)
    {
        // Проверка на пустой массив
        if (args == null || args.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        // Инициализация минимального значения первым элементом массива
        IComparable min = (IComparable)args.GetValue(0);

        // Проход по всем элементам массива для поиска минимума

        for (int i = 1; i < args.Length; i++)
        {
            IComparable current = (IComparable)args.GetValue(i);
            if (current.CompareTo(min) <0)
            {
                min = current;
            }    
        }

        return min;
    }
}