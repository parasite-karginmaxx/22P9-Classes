// Задание - " https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit "
using System.Runtime.CompilerServices;
namespace Classes
{
    public class Speciality
    {
        private string? title; //Название
        public string? reduction; //Сокращение
        Speciality(string? title, string? reduction)
        {
            this.title = title;
            this.reduction = reduction;
        }
    }

}
