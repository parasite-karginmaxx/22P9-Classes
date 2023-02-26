//https://docs.google.com/document/d/1mwSWGxZfPEK4Ysyh9TJ4A_Ym1bew2ttNGWbMpK9y_zc/edit

using ClassesLibrary;

while (true)
{
    Console.WriteLine("Введите имя класса:");
    switch (Console.ReadLine())
    {
        case "Никита бездарь(шучу)":
            Console.WriteLine(CreateTypeOccupation().Name);
            break;
        default:
            Console.WriteLine("Введите другое название");
            break;
    }
}

static TypeOccupation CreateTypeOccupation()
{
    Console.Write("Введите название занятия: ");
    return new TypeOccupation(Console.ReadLine() ?? "Нет названия");
}

namespace ClassesLibrary
{
    public class TypeOccupation
    {
        private readonly string name;
        public string Name { get => name; }
        public TypeOccupation(string name)
        {
            this.name = name;
        }
    }
}