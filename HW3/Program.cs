// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(int number)
{
    if(number >= 10000 && number <= 99999)
    {
        int num1 = number / 10000;
        int num5 = number % 10;
 
            if(num1 == num5)
            {
                number = number / 10;
                int num2 = (number / 100) % 10;

                int num4 = number % 10;
                if(num2 == num4)
                    Console.WriteLine("Число является палиндромом");
            }
            else 
            Console.WriteLine("Число НЕ является палиндромом");
            
    }
    else
    Console.WriteLine("Не соответсвует условиям, введите пятизначное число.");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int a){
    Console.Write(a * a * a + " , ");
}
Console.WriteLine("Введите цифру: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int i = 1; 
 while(i <= n){
    Cube(i);
    i++;
 }*/
