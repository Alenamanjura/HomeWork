Console.Clear();
Console.Write("Введите натуральное число: ");
string inputNum = (Console.ReadLine()!);
int n = int.Parse(inputNum);
string outNumLine = string.Empty;
int count = 0;

while(count < n){
    outNumLine = outNumLine + count + ",";
    count = +1;
}

Console.WriteLine(outNumLine + n);

