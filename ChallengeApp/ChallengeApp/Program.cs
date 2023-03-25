using ChallengeApp;


Employee em1 = new Employee("Adam", "Adamczyk", 20);
Employee em2 = new Employee("Beata", "Budna", 30);
Employee em3 = new Employee("Cyprian", "Cybulski", 40);

em1.AddScore(3); em2.AddScore(3); em3.AddScore(1);
em1.AddScore(2); em2.AddScore(7); em3.AddScore(-2);
em1.AddScore(3); em2.AddScore(-10); em3.AddScore(6);
em1.AddScore(2); em2.AddScore(1); em3.AddScore(2);
em1.AddScore(0); em2.AddScore(9); em3.AddScore(4);

List<Employee> emS = new List<Employee>()
    {em1, em2, em3};

int maxResult = -1;
Employee emWithMaxResult = null;

foreach(var em in emS)
{
    if(em.Result> maxResult)
    {
        maxResult = em.Result;
        emWithMaxResult = em;
    }
}
Console.WriteLine("The Winner is:");
Console.WriteLine("Name: " + emWithMaxResult.Name);
Console.WriteLine("Surname: " +emWithMaxResult.Surname);
Console.WriteLine("Age: " + emWithMaxResult.Age);
Console.WriteLine("You have: " + emWithMaxResult.Result + " points");