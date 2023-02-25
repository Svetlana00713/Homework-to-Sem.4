//Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(a); 
int[] b = str.Select(number => Convert.ToInt32
(Char.GetNumericValue(number))).ToArray(); 

int sum = 0;
for (int i = 0; i < b.Length; i++)
{  
    sum += b[i];
}
Console.WriteLine("Сумма элементов массива: " +sum);


 
    
    
  
