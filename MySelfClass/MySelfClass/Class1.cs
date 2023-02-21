using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary;
#region Вариант 23
// https://docs.google.com/document/d/1DUF8Z0-MH7np4AlSFXN5TYCDiut7WdsESiPi-BS8j-4/edit
#endregion
public class MySelfTraining
{
    private string name; // название
    private object Employee; // ссылка на сотрудника
    List<student> student; // список ссылок на студентов
    MySelfTraining(string name, object student, object Employee) // конструктор
    {
        this.name = name;
        this.student = student;
        this.Employee = Employee;
    }
}


