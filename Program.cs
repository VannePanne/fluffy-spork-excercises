static string Greet(string namePassedIn)
{
  return "Welcome to SALT, " + namePassedIn;
}

static string DateToCourse(DateTime courseDate)
{
  int daysLeft = (courseDate - DateTime.Today).Days;
  return "Today it is " + daysLeft + "days left until the course starts.";
}
//test
Console.Write("What is your name? ");
var name = Console.ReadLine()!;

Console.Write("When does that course start? ");
var currentDate = Console.ReadLine()!;
DateTime courseDate = DateTime.Parse(currentDate);

var countDown = DateToCourse(courseDate);
var greeting = Greet(name);

Console.WriteLine(greeting);
Console.WriteLine(countDown);
