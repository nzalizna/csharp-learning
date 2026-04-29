// To jest komentarz

/*
   To jest komentarz
   wieloliniowy
*/

// To jest komentarz / це коментар
// Komentarz wieloliniowy / багаторядковий коментар:
/*
   To jest komentarz
   wieloliniowy
*/

// 1. Zmienne / Змінні / Variables
// Deklaracja z inicjalizacją / Оголошення з ініціалізацією
// [typ danych] [nazwa] = [wartość];
int wiek = 0;
wiek = 10 + 20; // wyrażenie / вираз / expression
wiek = 40 / 10;
// literal - kawałek danych / літерал - шматочок даних: 10, 'A', "Ala"
// wyrażenie - łączy literały operatorem / вираз - з'єднує літерали оператором: 10+10
Console.WriteLine(wiek);

// 2. Typy danych / Типи даних / Data types
// 2.1. Proste (prymitywne) / Прості (примітивні) / Primitive
// Przechowują tylko dane / Зберігають тільки дані
int age = 25;           // liczba całkowita / ціле число / integer - WAŻNY!
long duzaLiczba = 334433; // duża liczba całkowita / велике ціле число
double temp = 25.5;     // liczba zmiennoprzecinkowa / дробове число / decimal - WAŻNY!
char znak = 'A';        // pojedynczy znak / один символ / single character
bool czyPadaDeszcz = true; // prawda/fałsz / правда/неправда / true/false - WAŻNY!

// 2.2. Złożone (complex) / Складні / Complex
// Przechowują dane + mają metody / Зберігають дані + мають методи
string zdanie = "Ala ma kota"; // łańcuch znaków / рядок тексту / string
// Metoda ToUpper() - zamienia tekst na wielkie litery
// Метод ToUpper() - перетворює текст на великі літери
string noweZdanie = zdanie.ToUpper();
Console.WriteLine(noweZdanie);

Console.ReadLine();