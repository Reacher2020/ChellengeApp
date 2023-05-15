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

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            int grade = 0;
            do
            {
                statistics.Min = Math.Min(statistics.Min, this.Grades[grade]);
                statistics.Max = Math.Max(statistics.Max, this.Grades[grade]);
                statistics.Average += this.Grades[grade];
                grade++;
            } while (grade < this.Grades.Count);

            statistics.Average /= this.Grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            int grade = 0;

            while (grade < this.Grades.Count);
            {
                statistics.Min = Math.Min(statistics.Min, this.Grades[grade]);
                statistics.Max = Math.Max(statistics.Max, this.Grades[grade]);
                statistics.Average += this.Grades[grade];
                grade++;
            } 
            statistics.Average /= this.Grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            for (int grade=0;grade < this.Grades.Count;grade++)
            {
                statistics.Min = Math.Min(statistics.Min, this.Grades[grade]);
                statistics.Max = Math.Max(statistics.Max, this.Grades[grade]);
                statistics.Average += this.Grades[grade];
            }
            statistics.Average /= this.Grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithForeach()
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
