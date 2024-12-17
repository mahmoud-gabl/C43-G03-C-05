namespace Dimo5
{
    internal class Program
    {
        //public static void swap(ref int x,ref int y)
        //{ 
        // int temp=x; x=y; y=temp;
        //}
        //public static void project(string pattern, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("*");
        //    }
        //}
        //public static int pet(ref int[] Arr)
        //{
        //    int sum=0;

        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #region params
        //public static int sumarray( params int[] Arr)
        //    {
        //    int sum = 0;
        //        if (Arr != null)
        //            {
        //             for (int i = 0; i < Arr.Length; i++)
        //             sum += Arr[i];                      
        //            }
        //        return sum;
        //    }
        #endregion


        static void Main(string[] args)
        {
            #region passing ref by value
            //int x = 3;
            //int y = 4;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //swap(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region ref by type
            //int[] numbers = { 1, 2, 3};
            //int result=pet(ref numbers);
            //Console.WriteLine(result);

            #endregion
            #region passing by out
            //int a = 3, b = 4, resultsm ,  resultmul ;
            //summul(a,b,out resultsm ,out resultmul);
            //Console.WriteLine($"sum{resultsm}");
            //Console.WriteLine($"mul{resultmul}");


            #endregion
            #region params
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = sumarray(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //Console.WriteLine($"sum of number {sum}");
            #endregion
            #region boxing & boxing
            //int x = 10;
            //object y = x;  
            //Console.WriteLine(y);
            ////boxing 
            ////casting from value type to referance type {safe casting}

            ////---------------unboxing---------------
            //object z = 10;
            //z = "mahmoud";
            //int xr = (int)z;
            //Console.WriteLine(xr);
            ////unboxing
            ////casting from referance type to value type {unsafe casting}


            #endregion
            #region nullable code
            //int? number; // Nullable<int>number
            //number = 3;
            //number = null;

            ////----------double---------------
            //double? number2; // Nullable<double>number2;
            //number2 = 48;

            //-----------null forgiveness--------------------

            //number2 = null;
            //string name = "mah";
            //name = null;
            //string? name2=null;
            //Console.WriteLine(name);
            //Console.WriteLine(name2);

            //string notnull = "";
            //string? nallable=null;
            //notnull = nallable!; //null forgiveness {!}



            #endregion
            #region how work nullable
            //int x = 10;
            //int? y = 20;
            //y = null;
            //y = x;

            // -----------------*unboxing*------------
            //int? x = 20;
            //x = null;
            //int y = 30;
            //y = (int)x;
            // y = x.HasValue ? x.Value : y;
            //y = x ?? 0;

            #endregion
            #region null propagation
            //double x = default;
            //int[]? numbers = default;

            //if (numbers != null)
            //{ 
            // for (int i = 0; i < numbers?.Length; i++)
            //    {
            //        x = numbers[i];
            //    }

            //}

            //numbers != null ? numbers.Length : 0; // null propagation
            //int length = numbers?.Length ?? 0; // coleasing 
            #endregion
        }
    }
}
