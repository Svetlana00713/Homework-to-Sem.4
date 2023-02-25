// Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

System.Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rnd = new Random();
for(int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(0, 100);
}
Console.WriteLine(string.Join(", ", arr));

