Console.Clear();
Console.Write("Введите число от отрезка [10, 99]: ");
int number = int.Parse(Console.ReadLine()!);


while(number < 10 || number > 99){
Console.WriteLine($"Ошибка: Вы ввели числа меньше 10 либо больше 99.\n Попробуйте снова");
number = int.Parse(Console.ReadLine()!);
}
if (number > 10 || number < 99){
                    
          Console.WriteLine("Наибольшая цыфра этого числа: " + number / 10);          
}
else {
Console.WriteLine("Наибольшая цыфра этого числа: "+ number % 10);
}