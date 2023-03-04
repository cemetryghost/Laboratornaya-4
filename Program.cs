namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[7];

            students[0] = new Student("Марусик", "Матвей", "Даниилович", 201, new int[] { 4, 5, 5, 5, 5 });
            students[1] = new Student("Михотин", "Иван", "Александрович", 211, new int[] { 3, 3, 3, 5, 5 });
            students[2] = new Student("Иванов", "Дмитрий", "Андреевич", 213, new int[] { 5, 5, 4, 5, 4 });
            students[3] = new Student("Байкин", "Никита", "Дмитриевич", 201, new int[] { 3, 3, 2, 4, 5});
            students[4] = new Student("Коновалов", "Денис", "Александрович", 215, new int[] { 4, 4, 4, 4, 3 });
            students[5] = new Student("Русинов", "Юрий", "Дмитриевич", 291, new int[] { 4, 5, 4, 5, 4 });
            students[6] = new Student("Иванов", "Никита", "Максимович", 298, new int[] { 4, 3, 5, 3, 5 });

            var sortedStudents = students.OrderBy(n => n.average);

            foreach (Student student in sortedStudents)
            {
                student.PrintStudent();
            }
        }

        struct Student
        {
            public string surname, name, patronymic;
            public int group;
            public int[] assessment;
            public double average;

            public Student(string surname, string name, string patronymic, int group, int[] assessment)
            {
                this.name = name;
                this.surname = surname;
                this.patronymic = patronymic;
                this.group = group;
                this.assessment = assessment;
                average = assessment.Average();
            }

            public void PrintStudent() => Console.WriteLine($"Фамилия: {surname}, Имя: {name}, Отчество: {patronymic}, Группа: {group}, Ср. балл: {average}");
        }
    }
}