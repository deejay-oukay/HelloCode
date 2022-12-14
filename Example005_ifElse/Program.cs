Console.Write("Как Вас зовут? ");
string username = Console.ReadLine();
if (username.ToLower() == "константин")
    Console.WriteLine("Здравствуй, хозяин");
else
    Console.WriteLine("Привет, "+username+"!");
