namespace ChellengeApp
{
    public class Employee
    {
        public List<float> Grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name; 
            this.Surname = surname;
        }

        public string Name { get; private set;  }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Inwalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float.");
            }
        }
 
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.Grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade; 
            }
            statistics.Average /= this.Grades.Count;

            return statistics;
        }
    }
}
