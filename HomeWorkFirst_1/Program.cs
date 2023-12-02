Console.Clear();
Console.Write("Введите число: ");
int firstNumder = int.Parse(Console.ReadLine()!);
if(firstNumder % 161 == 0)
 Console.WriteLine($"Число {firstNumder} кратно одновременно 7 и 23");
else {
                    Console.WriteLine($"Число {firstNumder} не кратно одновременно 7 и 23");
}
