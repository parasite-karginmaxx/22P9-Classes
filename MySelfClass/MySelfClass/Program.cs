using ClassesLibrary;

while (true)
{
    Console.WriteLine("Какой класс Вы хотите создать?");
    switch (Console.ReadLine())
    {
        case "MySelftTraining":
            Console.WriteLine(CreateMySelfTraining().name);
            break;
        default:
            Console.WriteLine("Такого класса не существует");
            break;
    }
    Console.WriteLine("Руководитель");
    switch (Console.ReadLine())
    {
        default:
            Console.WriteLine("Такой руководитель отсутствует");
            break;
    }
}
