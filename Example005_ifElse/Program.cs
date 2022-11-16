Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лена")
{
    Console.WriteLine("Припет, плюшка!=)");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
