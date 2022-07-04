// показать четные числа от 1 до n
Console.WriteLine("введите число ");
int n=int.Parse(Console.ReadLine());
int res=1;
while (res<n)

{
    Console.Write(res+1);
    Console.WriteLine("  чётное число ");
res+=2;
}