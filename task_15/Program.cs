/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
 */
System.Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (0 < number & number < 8)
{
	if (0 < number & number < 6)
	{
		System.Console.WriteLine("Нет.");
	}
	else
	{
		System.Console.WriteLine("Да.");
	}
}
else
{
	System.Console.WriteLine("Вы ввели цифру не в диапазоне от 1 до 7!");
}