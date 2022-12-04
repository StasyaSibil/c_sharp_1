// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine());
int max = 0;
if(a>b){
    max = a;

}
else {
    max = b;
}

if (c>max){
    max = c;
}

Console.WriteLine("Максимальное число равно "+ max);