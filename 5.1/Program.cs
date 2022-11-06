//Миронова Анастасия 22-ИСП-2/1
//5.1 Вариант 4
//Уровень Сложный

char[] str = new char[11];
str = Console.ReadLine().ToCharArray();


int a = 1;
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i] + " ");
    a *= (int)(Char.GetNumericValue(str[i]));

}
Console.WriteLine(a);