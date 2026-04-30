Console.WriteLine("Podaj swoje imie");
string imie = Console.ReadLine();
Console.WriteLine("Podaj swój wiek");
int wiek = int.Parse(Console.ReadLine());
int rokUrodzenia = DateTime.UtcNow.Year - wiek;
string pelneZdanie = "Twoje imie to " + imie + "\nTwoj wiek to " + wiek;
Console.WriteLine(pelneZdanie);
Console.WriteLine("Urodziles sie pewnie w roku " + rokUrodzenia);
Console.ReadLine();
