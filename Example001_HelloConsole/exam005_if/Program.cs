Console.Clear();
Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "max")
{
    Console.WriteLine("Максим,идём поссым.))");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}