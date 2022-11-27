// 15. С клавиатуры вводится число. Вывести третью цифру числа или сообщить, что ее нет.
// (Вывести: NO).
int n=Convert.ToInt32(Console.ReadLine());
//Вариант 1-простой
/*if (n<100) System.Console.WriteLine("NO");
else System.Console.WriteLine(n/100%10);
//4445766/100%3
*/

//Вариант 2- 12345678-3

if (n>99)
{
while (n>1000)
{
    n=n/10;
}
System.Console.WriteLine(n%10);
}

else
{
    System.Console.WriteLine("NO");
}