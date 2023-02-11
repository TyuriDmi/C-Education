// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя");
string name = Console.ReadLine();
if (name.ToLower() == "дима")
{
    Console.WriteLine("Вот это да, это же целый ДИМА!");
}
else 
{
    Console.Write("Ну привет, ");
    Console.WriteLine(name);
}