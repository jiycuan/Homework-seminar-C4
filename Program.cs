// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B
// Степень числа - результат многократного умножения числа на себя.

/*
Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень нужно возвести число? Укажите цифру: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;

while (B > 1)
    {
        result = result*A;
        B--;
    }
Console.WriteLine($"Результат возведения числа {A} в указанную степень равен {result}");
*/

// Программа, которая принимает на вход число и выдаёт сумму цифр в числе

/*
Console.WriteLine("Введите число, сумму цифр которого необходимо посчитать: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0;

while (num > 0)
    {
        temp = temp + (num%10);
        num = num/10;
    }
Console.WriteLine($"Результат равен {temp}");
*/

// Программа, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив

/*
int size = 8;
int[] array = new int[size];
int temp;

for (int i = 0; i < size; i++)
    {
        Random rand = new Random();
        temp = rand.Next(-1000, 1000);
        array[i] = temp;
    }
    for (int a = 0; a < size; a++)
        {
            int position = a;
            
            for (int b = a + 1; b < size; b++)
                {
                    if (Math.Abs(array[b]) < Math.Abs(array[position])) position = b;
                }
            int curr = array[a];
            array[a] = array[position];
            array[position] = curr;

    Console.Write($"{array[a]}, ");
    }
Console.WriteLine();
*/