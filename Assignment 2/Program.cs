public class assignment
{

    public static void Main(string[] args)
    {

        int n = 5;
        int[] boo = { 0, 1, 2, 3, 4 };

        int m = 100;
        int[] bar = new int[100];

        for (int i = 0; i < m; i++)
        {

            bar[i] = i;
        }
        Console.WriteLine("The total number of even numbers in foo are: ");
        Console.WriteLine(countEvenNum(boo, n));
        Console.WriteLine("The total number of even numbers in bar are: ");
        Console.WriteLine(countEvenNum(bar, m));
    }

    public static int countEvenNum(int[] arr, int size)
    {

        int count = 0;

        for (int i = 0; i < size; i++)
        {

            if (arr[i] % 2 == 0)
            {

                count++;
            }
            else
            {
            }
        }
        return count;
    }
}