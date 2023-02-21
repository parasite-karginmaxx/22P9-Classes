using ClassesLibrary;

while (true)
{
    Console.WriteLine(CreateName().shfitname);
    break;
}
    static Shift CreateName()
{
    Console.Write("Введите навзание смены: ");
    return new Shift (Console.ReadLine() ?? "Нет названия");
}
