namespace ConsoleAppStudentsTask3
{
    internal class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string Speciality { get; set; }
            public int GroupNo { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("Telebe melumati daxil edin yadaki 'done' duymesini vuraraq bitirin: ");
                string input = Console.ReadLine();

                if (input == "done")
                {
                    break;
                }

                string[] values = input.Split(' ');

                if (values.Length != 5 || !int.TryParse(values[2], out int age) || !int.TryParse(values[4], out int groupNo))
                {
                    Console.WriteLine("Yeniden daxil edin!");
                    continue;
                }
                Student student = new Student
                {
                    Name = values[0],
                    Surname = values[1],
                    Age = age,
                    Speciality = values[3],
                    GroupNo = groupNo
                };

                students.Add(student);

            }
            foreach (Student student in students)
            {
                Console.WriteLine("Name: {0}", student.Name);
                Console.WriteLine("Surname: {0}", student.Surname);
                Console.WriteLine("Age: {0}", student.Age);
                Console.WriteLine("Speciality: {0}", student.Speciality);
                Console.WriteLine("Group Number: {0}", student.GroupNo);
                Console.WriteLine();
            }
        }
    }
}