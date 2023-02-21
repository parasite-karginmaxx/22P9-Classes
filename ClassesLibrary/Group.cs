namespace ClassesLibrary
/* https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit */
{
    public class Group
    {
        private string? name;
        private string? sokr;
        private int? chisl = 0;
        private int? year = 0;
        private readonly Speciality speciality;
        public Speciality Speciality { get => speciality; }
        private readonly ClassTeacher classteacher;
        public ClassTeacher ClassTeacher { get => classteacher; }

        public Group(string? name, string? sokr, int? chisl, int? year, Speciality speciality, ClassTeacher classteacher)
        {
            this.name = name;
            this.sokr = sokr;
            this.chisl = chisl;
            this.year = year;
            this.speciality = speciality;
            this.classteacher = classteacher;

        }
    }
}
        