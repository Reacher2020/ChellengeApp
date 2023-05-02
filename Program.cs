Employee employee1 = new Employee("Adam", "kowalski",30);
Employee employee2 = new Employee("Ewa", "Nowak", 28);
Employee employee3 = new Employee("Karol", "Mickiewicz", 46);
Employee employee4 = new Employee("Natalia", "Gorska", 57);

Random rnd = new Random();
int winner;

for (int i=0;i < 5; i++)
{
    employee1.AddScore( rnd.Next(1,11));
    employee2.AddScore( rnd.Next(1,11));
    employee3.AddScore( rnd.Next(1,11));
    employee4.AddScore( rnd.Next(1,11));
}

if (employee1.TotallScore > employee2.TotallScore)
{
    if (employee1.TotallScore > employee3.TotallScore)
    {
        if(employee1.TotallScore > employee4.TotallScore)
        {
            winner = 1;
        }
        else 
        {
            winner = 4;
        }
    }
    else
    {
        if(employee3.TotallScore > employee4.TotallScore)
        {
            winner = 3;
        }
        else 
        {
            winner = 4;
        }
    }
}
else
{ 
    if (employee2.TotallScore > employee3.TotallScore)
    {
        if(employee2.TotallScore > employee4.TotallScore)
        {
            winner = 2;
        }
        else
        {
            winner = 4;
        }
    }
    else 
    {
        if (employee3.TotallScore > employee4.TotallScore)
        {
            winner = 3;
        }
        else
        {
            winner = 4;
        }
    }
}
if (winner == 1)
{
    Console.WriteLine(employee1.Imie + "  " + employee1.Nazwisko + " Wiek " + employee1.Wiek + " TotallScore " + employee1.TotallScore);
} 
else if (winner == 2)
{
    Console.WriteLine(employee2.Imie + "  " + employee2.Nazwisko + " Wiek " + employee2.Wiek + " TotallScore " + employee2.TotallScore);
}
else if (winner == 3)
{
    Console.WriteLine(employee3.Imie + "  " + employee3.Nazwisko + " Wiek " + employee3.Wiek + " TotallScore " + employee3.TotallScore);
}
else
{
    Console.WriteLine(employee4.Imie + "  " + employee4.Nazwisko + " Wiek " + employee4.Wiek + " TotallScore " + employee4.TotallScore);
}



class Employee
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
