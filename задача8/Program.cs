// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число N");
int n =int.Parse(Console.ReadLine());
int i = 0;

while(i<n){

    i=i+1;
    if(i%2>0){
        Console.WriteLine(i+" число нечётное");
    }
    else{
        Console.WriteLine(i+" число чётное");
    }
}
