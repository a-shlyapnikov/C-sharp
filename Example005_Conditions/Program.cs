Console.Write("Введите имя пользователя ");
string userName = Console.ReadLine();

if (userName.ToLower() == "настя")
{
    Console.WriteLine("Ура, это же Настя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}