namespace NullableStructEnumIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomResize<int> arr = new CustomResize<int>();
            arr[0] = 13;
            arr.Add(1);
            Console.WriteLine(arr);
            arr.AddRange(1, 3, 534, 465, 465, 47, 47, 47545, 74);
            Console.WriteLine(arr);
            arr.AddRange(1, 2, 3, 4, 465, 465, 47, 47, 475);
            Console.WriteLine(arr);
            arr.RemoveRange(3, 4, 46);

            Console.WriteLine(arr);

            Console.WriteLine(arr.CountMethod());
            arr.Sum();



        }
    }
}
