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