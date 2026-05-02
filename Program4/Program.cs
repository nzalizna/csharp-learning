// Tablice / Масиви
double[] oceny = new double[10];
oceny[0] = 45 / 2.0 + 10;
oceny[1] = 12;
oceny[2] = (oceny[0] + oceny[1]) / 2;
Console.WriteLine(oceny[0]);
Console.WriteLine(oceny[1]);
Console.WriteLine(oceny[2]);


// Tablica stringów / Масив рядків
string[] imiona = new string[10];
imiona[0] = "Jan";
imiona[1] = "Anna";
imiona[2] = "Andrzej";


// Krótszy zapis / Коротший запис
string[] imiona2 = { "Jan", "Anna", "Andrzej" };
int rozmiar = imiona2.Length;
Console.WriteLine(imiona2[imiona2.Length - 1]);


// Kolekcje / Колекції
// List<string> = динамічний масив рядків
// <string> = тип елементів всередині
// new List<string>() = створюємо порожній список
List<string> nazwiska = new List<string>();

// .Add() = додати елемент в кінець списку
nazwiska.Add("Kowalski");
nazwiska.Add("Andrzejewski");
nazwiska.Add("Smith");
nazwiska.Add("Doe");

// .Remove() = видалити елемент зі списку
// якщо елемента немає - нічого не відбувається
nazwiska.Remove("Jones");

// nazwiska[1] = елемент на індексі 1 (другий елемент)
Console.WriteLine(nazwiska[1]);

// .Count = кількість елементів в List
// (аналог .Length для масивів)
Console.WriteLine(nazwiska.Count);
Console.ReadLine();



// For — найчастіше використовується з масивами
double[] oceny2 = new double[] { 4, 3, 5, 3, 4 };
double srednia = 0;

for (int i = 0; i < oceny2.Length; i++)
{
    srednia += oceny2[i];
}
srednia /= oceny2.Length;
Console.WriteLine(srednia);