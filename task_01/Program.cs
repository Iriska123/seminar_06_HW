/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
пользователь. (Можно изучить метод Split.
Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, где первый аргумент
 это разделитель чисел, второе обработчик введеной последовательности)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/


int M = 5;
Console.WriteLine($"Введите {M} чисел через пробел: ");
string enter = Console.ReadLine();
string[] array = enter.Split(" ", StringSplitOptions.RemoveEmptyEntries);


Console.WriteLine(String.Join(",",array));

int result = Console.WriteLine(CountNums(array)!);

int CountNums(string[] array){
    int count = 0;
    foreach (string item in array)
    {
        //int v = Convert.ToInt32(item.ToString());
        if(Convert.ToInt32((item.ToString())) > 0) {
            count++;
        }
    }
    Console.WriteLine(count);
return count;
}

