Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "igor")
{
    Console.WriteLine("Ура,это же Igor");
}
else
{
    Console.Write("Привет!, ");
    Console.WriteLine(username);
}