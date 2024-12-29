namespace Assignment_5
{
    internal class Program
    {
        public static void SumSub_Passing_by_value1(int a, int b, int c, int d)
        {
            int sum = a + b;
            int sub = c - d;
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumSub_Passing_by_reference1(ref int a, ref int b, ref int c, ref int d)
        {
            int sum = a + b + c + d;
            int sub = a - b - c - d;
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumSub_Passing_by_value2(int[] arr)
        {
            int sum = 0, sub = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sub -= arr[i];
            }
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumSub_Passing_by_reference2(ref int[] arr)
        {
            int sum = 0, sub = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sub -= arr[i];
            }
            Console.WriteLine($"Sum: {sum}, Sub: {sub}");
        }
        public static void SumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of digits: {sum}");
        }
        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void MinMaxArray(ref int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }
        public static int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static string ChangeChar(ref string str, int idx, char ch)
        {
            char[] arr = str.ToCharArray();
            arr[idx] = ch;
            str = new string(arr);
            return str;
        }
        static void Main(string[] args)
        {
            #region 1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable C# example
            int a = 10, b = 20, c = 30, d = 40;
            Console.WriteLine("Passing by value:");
            SumSub_Passing_by_value1(a, b, c, d);
            SumSub_Passing_by_reference1(ref a, ref b, ref c, ref d);
            #endregion

            #region 2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable C# example.
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Passing by value:");
            SumSub_Passing_by_value2(arr);
            SumSub_Passing_by_reference2(ref arr);
            #endregion

            #region 3. Write a C# Function that accepts 4 parameters from user and returns result of summation and subtraction of two numbers.
            int x, y, z, w;
            Console.WriteLine("Enter 4 numbers:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            SumSub_Passing_by_value1(x, y, z, w);
            #endregion

            #region 4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            int num;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            SumDigits(num);
            #endregion

            #region 5. Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not.
            int num5 = int.Parse(Console.ReadLine());
            if (IsPrime(num5))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            #endregion

            #region 6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters.
            int[] arr6 = { 1, 2, 3, 4, 5 };
            int min = 0, max = 0;
            MinMaxArray(ref arr6, ref min, ref max);
            Console.WriteLine($"Min: {min}, Max: {max}");
            #endregion

            #region 7. Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter.
            int num7 = int.Parse(Console.ReadLine());
            int fact = factorial(num7);
            Console.WriteLine(fact);
            #endregion

            #region 8. Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter.
            int idx = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());
            string newStr = ChangeChar(ref str, idx, ch);
            Console.WriteLine(newStr);
            #endregion
            /*
             * -----------------------------------------------------------------------------------------
             * Demo
             * 
             */

            #region Array Methods 
            //int[] numbers = { 5, 3, 4, 1, 2, 4 };
            //Array.Sort(numbers); //  1, 2, 3, 4,4, 5
            //Array.Reverse(numbers); // 4, 2, 1, 4, 3, 5
            //Array.Clear(numbers); // 0,0,0,0,0,0
            //Array.Clear(numbers, 2, 2); // 5,3,0,0,2 ,4
            //Console.WriteLine(Array.IndexOf(numbers, 4)); // 2
            //Console.WriteLine(Array.LastIndexOf(numbers, 4)); // 5
            //Array.Resize(ref numbers, 10); // 5, 3, 4, 1, 2, 4 , 0 ,0,0,0


            //foreach (int num in numbers)
            //{
            //	Console.WriteLine(num);
            //}

            //int[] Arr01 = { 1, 2, 3, 4, 5 };
            //int[] Arr02 = new int[4];
            ////Array.Copy(Arr01, Arr02, 4); // 1, 2, 3, 4
            //Array.ConstrainedCopy(Arr01, 1, Arr02, 1, 2); // 0,2,3,0
            //foreach (int num in Arr02)
            //{
            //	Console.WriteLine(num);  
            //}
            #endregion

            #region Functions 

            #region Function Prototype
            ///////*Program.*/PrintShape(); // *      *      *      *      *
            ////PrintShape(15 , ":)");  // Passing Parameters By Order
            ////PrintShape(pattern : "*_*" , count : 10); // Passing Parameters By Name
            //////PrintShape(); // Using Default Values 
            //////PrintShape(pattern : "*_*"); // Using Default Value of Count 
            ////PrintShape(4); // Using Default Values 
            ///////  /*\
            ////PrintShape ("/*\"); // Invalid [ Escape Sequences]


            //Console.WriteLine("Welcome Aliaa \rHello Amr"); // Hello Amrliaa
            //Console.WriteLine("Hello\bWorld!"); 
            //Console.WriteLine(@"Hello\World!");
            //int X = 10;
            //Console.WriteLine($"Hello {X} World!");  // Hello 10 World!
            //Console.WriteLine($"Hello {{X}} World!");// Hello {X} World!
            //Console.WriteLine("Name:Aliaa\tAge:25"); // Name:Aliaa      Age:25
            //										 /////  /*\

            //PrintShape(10 , "/*\\"); 
            #endregion

            #region Function Parameters [Value Type]

            #region Passing by Value 
            //int A = 10, B = 5;
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5
            //SWAP(A, B); // Passing By Value
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5 
            #endregion

            #region Passing By Reference 

            //int A = 10, B = 5;
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5
            //SWAP(ref A, ref B); // Passing By Reference
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"A = {A}"); // 5
            //Console.WriteLine($"B = {B}"); // 10

            #endregion

            #endregion

            #region Function Parameters [Reference Type]

            #region Example 01 

            #region Passing By Value
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers); // Passing By Value [Address]
            //Console.WriteLine(numbers.GetHashCode());
            //Console.WriteLine($"Sum =  {result}"); // 105
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 100


            #endregion

            #region Passing by Reference 
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers); // Passing By Reference [Reference of Array : numbers]
            //Console.WriteLine($"Sum =  {result}"); // 105
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 100
            #endregion

            #endregion

            #region Example 02 

            #region Passing By Value

            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers); // Passing By Value [Address]
            //Console.WriteLine($"Sum =  {result}"); // 100
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 1

            #endregion

            #region Passing by Reference 

            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers); // Passing By Reference [Reference of array [numbers]]
            //Console.WriteLine($"Sum =  {result}"); // 100
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 10

            #endregion

            #endregion

            #endregion

            #region Function Parameters [Passing By out]


            //int a = 10, b = 3, SumResult, SubResult;

            //SumSub(a, b, out SumResult, out SubResult); // Passing By Out
            //Console.WriteLine($"Sum Result = {SumResult}"); // 13
            //Console.WriteLine($"Sub Result = {SubResult}"); // 7

            #endregion

            #region Function Parameters [Params]
            #region Before C# 13
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int Result = SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9); //C# will convert it to an array internally
            //Console.WriteLine($"Sum = {Result}"); // 45
            //string message = string.Format("Hello {0} Your Age is {1}", "Aliaa", 26); //Hello Aliaa Your Age is 26
            //Console.WriteLine(message); 
            #endregion

            #region After C# 13 

            //Concat<object>("Hello Ahmed", "Welcome To Route", "Your Number Is", 123456 , "Data is" , DateTime.Now);
            //// Hello Ahmed Welcome To Route Your Number Is 123456 Data is 12/18/2024 5:35:22 PM

            #endregion

            #endregion

            #endregion

            #region Boxing , Unboxing 

            #region Boxing [Value Type => Reference Type]

            //int X = 100;

            //object obj = X; // Boxing 
            //				// Take Copy From Value and Wrapping the value in an object
            //obj = 1.2;    // Casting From  double  [valuetype] => To Object [Reference Type] ----> Boxing
            //obj = 'A';    // Casting From  char    [valuetype] => To Object [Reference Type] ----> Boxing
            //obj = 5.2f;   // Casting From  float   [valuetype] => To Object [Reference Type] ----> Boxing
            //obj = true;   // Casting From  bool    [valuetype] => To Object [Reference Type] ----> Boxing
            //obj = 1.2m;   // Casting From  decimal [valuetype] => To Object [Reference Type] ----> Boxing
            //			  // Implicit Casting 
            //			  // Safe Casting 

            //Console.WriteLine(obj); // 1.2 

            //obj = (object)'B'; // Boxing

            #endregion

            #region Unboxing [Reference Type => Value Type]

            //object obj = "Aliaa";
            //obj = new int[] { 1, 2, 3 };

            //int X = (int)obj;      // Casting From  Object [Reference Type] => To int [ValueType] ----> Unboxing
            //char input = (char)obj; // Casting From  Object [Reference Type] => To char [ValueType] ----> Unboxing
            //bool flag = (bool)obj;  // Casting From  Object [Reference Type] => To bool [ValueType] ----> Unboxing
            //						// Explicit Casting
            //						// Unsafe Casting 


            //Console.WriteLine(flag); //InvalidCastException:
            #endregion

            #endregion

            #region Nullable value types

            #region Example 01
            //int X = 10;
            ////X = null; // Invalid

            //Nullable<int> Y = 50;
            //Y = null; // Valid 

            //int? Z = 100;
            //Z = null; 
            #endregion

            #region Example 02 [Casting From nullable type to non-nullable type]

            //int X = 10;
            //int? Y = X; // Valid implicitly Casting

            //int? A = 10;
            //int B = (int)A; // Explicitly Casting 

            //A = null;
            //if (A is not null) B = (int)A;
            //else B = 0;

            //if (A.HasValue) B = A.Value;
            //else B = 0;

            //B = A.HasValue ? A.Value : 0;

            //      B = A ?? 0; //null-coalescing operator

            //   B = A.GetValueOrDefault();


            //Console.WriteLine(A); // null
            //Console.WriteLine(B); // 0

            #endregion

            #endregion

            #region Nullable Reference Types 

            //         #nullable disable

            //string name01 = null;
            //Console.WriteLine(name01);

            //         #nullable enable
            //string? name02 = null;
            //Console.WriteLine(name02);

            //string name03 = null!; 
            ////use the null-forgiving operator to suppress all nullable warnings for the expression.
            //Console.WriteLine(name03);

            #endregion

            #region Null-Conditional | Propagation operator

            //int[]? numbers = null;

            ////int arraylength = numbers?.Length ?? 0;

            ////int? Nullablearraylength = numbers?.Length;

            ////Console.WriteLine(arraylength);

            //for (int i = 0; i < numbers?.Length; i++)
            //{
            //	Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("==============================");

            //if (numbers != null)
            //{
            //	for (int i = 0; i < numbers.Length; i++)
            //	{
            //		Console.WriteLine(numbers[i]);
            //	}
            //}
            //else
            //{
            //	// Need Additional Action to Be Executed 
            //}

            #endregion    
        }
    }
}
