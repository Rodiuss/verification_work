int read_num() // На всяий случай 
{
    while (true)
    {
        try
        {
            Console.Write("Введите кол-во элементов: ");
            int units = Convert.ToInt32(Console.ReadLine());
            return units;
        }
        catch
        {
            Console.WriteLine("Неправильный формат, попробуйте снова!");
        }
    }
}

int units = read_num();

string?[] list = new string[units];
Console.WriteLine("Поочерёдно введите значения элементов: ");
string indexes = String.Empty;
int count = 0;

for (int i = 0; i < units; i++)
{
    Console.Write($"{i}: ");
    list[i] = Console.ReadLine();
    if (list[i].Length <= 3)
    {
        indexes += $"{i},";
        count++;
    }
}
