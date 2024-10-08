internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap kich thuoc cua mang");
        int size = int.Parse(Console.ReadLine());
        int[] myList = new int[size];
        int i = 0;
        while (i < size){
            Console.Write($"Nhap phan tu thu {i+1}: ");
            myList[i] = int.Parse(Console.ReadLine());
            i++;
        }
        Console.WriteLine("Cac phan tu cua mang:");
        foreach (int num in myList)
        {
            Console.Write(num + " ");
        }
        int max = myList[0];
        for(var j=0;j<myList.Length;j++){
            if(max < myList[j]){
                max = myList[j];
            }
        }
        Console.WriteLine("\nPhan tu lon nhat la: " + max);
    }
}