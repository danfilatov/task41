Console.Write("Введите M чисел через запятую: ");
//читаем числа с консоли заданных в одной строке
//int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
// пробелы, много пробелов
//int[] array = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item));
// запятая
int[] array = Array.ConvertAll(Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item));
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Чисел > 0: {count}");