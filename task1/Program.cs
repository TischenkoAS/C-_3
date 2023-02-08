// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!)!;

if (quarter == 1)
{
    Console.WriteLine("В первой четверти X>0 и Y>0.");
}
if (quarter == 2)
{
    Console.WriteLine("Во второй четверти X<0 и Y>0.");
}
if (quarter == 3)
{
    Console.WriteLine("В третьей четверти X<0 и Y<0.");
}
if (quarter == 4)
{
    Console.WriteLine("В четвёртой четверти X>0 и Y<0.");
}