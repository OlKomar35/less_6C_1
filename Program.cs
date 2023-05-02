// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void PrintArray(int[]arr){
    Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if(i!=arr.Length-1){
        Console.Write($"{arr[i]}, ");
    }else{
        Console.WriteLine($"{arr[i]}]");
    }
}
}

Console.Write("Введите количество цифр M=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через запятую: ");
string s = Console.ReadLine();
string [] stringArr = s.Split(new char[]{' ',',','.'},System.StringSplitOptions.RemoveEmptyEntries);

int[] numbers = stringArr.Select(Int32.Parse).ToArray();
PrintArray(numbers);
int count =0;
foreach (int num in numbers)
{
    if(num>0)count++;
}
Console.WriteLine($"Чисел больше 0 в введенном массиве ={count}");