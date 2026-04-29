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



// 3. Pułapki / Пастки
// 3.1. Typy zmiennoprzecinkowe / Числа з комою
double d1 = 1;
double d2 = 2;
double wynik = (d1 + d2) / 10;
Console.WriteLine(wynik);


// UWAGA! / УВАГА!
// Liczby zmiennoprzecinkowe nie są dokładne w systemie binarnym
// Числа з комою не є точними в бінарній системі
// Nigdy nie używaj double do obliczeń finansowych!
// Ніколи не використовуй double для фінансових розрахунків!
// Do obliczeń finansowych używaj typu decimal
// Для фінансових розрахунків використовуй тип decimal

// 3.2. Konwersje / Конвертація / Type conversion
int l1 = 10;
double l2 = 10.9;
double wynik2 = l1 + l2;
int wynik3 = (int)(l1 + l2);
int wynik4 = l1 + (int)l2;
Console.WriteLine(wynik2);
Console.WriteLine(wynik3);
Console.WriteLine(wynik4);
Console.ReadLine();

// rzutowanie / приведення типу / casting
// NIE zaokrągla, tylko odcina część ułamkową!
// НЕ округляє, а відрізає дробову частину!
// 10.9 -> 10 (nie 11!)


