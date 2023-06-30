Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, Маша!");
}
else
{
    Console.Write("Просто привет, ");
    Console.WriteLine(username);
}
