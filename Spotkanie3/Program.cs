// Metody / Методи
using Spotkanie3;

double[] oceny = new double[] { 4, 5, 2, 3, 2 };
double srednia = ObliczSrednia(oceny);
Console.WriteLine(srednia);

// Definicja metody / Визначення методу
double ObliczSrednia(double[] oceny)
{
    double suma = 0;
    foreach (double d in oceny)
    {
        suma += d;
    }
    return suma / oceny.Length;
}

double[] oceny2 = new double[] { 5, 4, 2, 4, 2, 3, 4 };
double srednia2 = ObliczSrednia(oceny2);
Console.WriteLine(srednia2);

// Obiekty / Об'єкти
// new Student() = створюємо новий об'єкт за шаблоном класу Student
Student st = new Student();
st.Id = 1;
st.Imie = "Jan";
st.Nazwisko = "Kowalski";
st.Oceny = new double[] { 4, 5, 2, 3, 2 };

Student st2 = new Student();
st2.Id = 2;
st2.Imie = "Jana";
st2.Nazwisko = "Rowalska";
st2.Oceny = new double[] {3, 4, 3, 5, 4};

// Wywołanie metod / Виклик методів
st.PrzedstawSie();
double srednia3 = st.ObliczSrednia();
Console.WriteLine(srednia3);

st2.PrzedstawSie();
double srednia4 = st2.ObliczSrednia();
Console.WriteLine(srednia4);