Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[num.ToString().Length];
int a = 0;
int b = 1;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = num % 10;
    num /= 10;
}
Array.Reverse(nums);
Console.WriteLine(string.Join(" ", nums));
for (int k = 0; k < nums.Length; k++)
{
    a += nums[k]; b *= nums[k];
}
int max = nums.Max();
int min = nums.Min();
Console.WriteLine($"Сумма чисел: {a}\r\nПроизведение чисел: {b}");
Console.WriteLine($"Максимальное значение: {max}\r\nМинимальное значение: {min}");