// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if( a > b )
{
    Console.WriteLine( "max"  + a );
}
else if( a < b)
{
    Console.WriteLine( "max"  + b );
}
else
{
    Console.WriteLine( "первое и второе число равны" );
}

