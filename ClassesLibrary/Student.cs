using System.Runtime.CompilerServices;

namespace ClassesLibrary
{
    public class Student
    {
        private string name; // имя
        private string s_name; // фамилия
        private string p_name; // отчество
        private object group; // будет ссылка на группу
        private DateTime date; // дата рождения
        Student ( string name , string s_name, string p_name,object group,DateTime date) // конструктор со всей фигней
        {
            this.name = name;
            this.s_name = s_name;
            this.p_name = p_name;
            this.group = group;
            this.date = date;
        }
    }
}