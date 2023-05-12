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
           this.Grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics(); ;

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
