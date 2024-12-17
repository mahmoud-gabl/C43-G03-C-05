namespace assignment_5
{
    internal class Program
    {
        #region ----1
        //public static void value(ref int x, ref int y)
        //{
        //    int num = x;
        //    x = y;
        //    y = num;
        //}
        #endregion
        #region ----2
        //public static int nums(int[] Arr)
        //{ 
        // int sum=0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    { 
        //     sum += Arr[i];
        //    }
        //    return sum;
        //}
        #endregion
        #region ----3
        //public static int sumsup(int x, int y, out int sum, out int sup)
        //{
        //    sum = x + y;
        //    sup = x-y;
        //    return 0;
        //}

        #endregion
        #region -----4
        //public static int sum(int number)
        //{
        //    int sum = 0;

        //    while (number > 0)
        //    {
        //        int digit = number % 10;

        //        sum += digit;

        //        number /= 10;
        //    }

        //    return sum;
        //}
        #endregion
        #region -----5
        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //    {
        //        return false;
        //    }

        //    if (number % 2 == 0 && number != 2)
        //    {
        //        return false;
        //    }

        //    for (int i = 3; i * i <= number; i += 2)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        #endregion
        #region -----6
        //public static void MinMaxArray(int[] arr, out int min, out int max)
        //{
        //    if (arr.Length == 0)
        //    {
        //        throw new ArgumentException("Array is empty.");
        //    }

        //    min = arr[0];
        //    max = arr[0];

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }

        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}
            #endregion
            static void Main(string[] args)
        {
            #region -----1 ref by value
            ////befor swap
            //int x = 4 , y = 6 ;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            ////after swap
            //value(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion
            #region -----2 ref by type
            //int[] numbers = { 1, 2, 3, 4, 5, 6};
            //int achion = nums(numbers);
            //Console.WriteLine($"this is nums of ref type {achion}");
            #endregion
            #region -----3
            //int x = 5;
            //int y = 7;
            //int sum, sup;
            //Console.WriteLine($"sum {x+y}");
            //Console.WriteLine($"sup {x-y}");
            #endregion
            #region -----4
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //int sumDigits = sum(num);

            //Console.WriteLine("The sum of the digits of the number {0} is: {1}", num, sumDigits);
            #endregion
            #region -----5
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsPrime(num))
            //{
            //    Console.WriteLine($"{num} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not a prime number.");
            #endregion
            #region -----6
            //int[] numbers = { 5, 2, 9, 1, 5, 6 };
            //int min, max;

            //MinMaxArray(numbers, out min, out max);

            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");
            #endregion
            #region ----7

            #endregion

        }
    
    }
}
