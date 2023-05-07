Employee employee1 = new Employee("Adam", "kowalski",30);
Employee employee2 = new Employee("Ewa", "Nowak", 28);
Employee employee3 = new Employee("Karol", "Mickiewicz", 46);
Employee employee4 = new Employee("Natalia", "Gorska", 57);

Random rnd = new Random();

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

int MaxTotallScore = -1;

Employee employeeWithMaxScore = null;

for (int i=0;i < 5; i++)
{
    foreach (var employee in employees)
    {
        employee.AddScore(rnd.Next(1, 11));
    }
}

foreach(var employee in employees)
{
    if (employee.TotallScore > MaxTotallScore)
    {
        employeeWithMaxScore = employee;
    }
}

Console.WriteLine(employeeWithMaxScore.Imie + "  " + employeeWithMaxScore.Nazwisko + " Wiek " + employeeWithMaxScore.Wiek + " TotallScore " + employeeWithMaxScore.TotallScore);

public class Employee
{
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public int Wiek { get; private set; }

    private List<int> score = new List<int>();

    public Employee(string imie, string nazwisko, int wiek)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        this.Wiek = wiek;
    }
    public void SetAge (int wiek)
    {
        this.Wiek = wiek;
    }

    public void AddScore (int score)
    {
        this.score.Add(score);
    }

    public int TotallScore { 
        get
        {
            return this.score.Sum();
        }
    }
}
