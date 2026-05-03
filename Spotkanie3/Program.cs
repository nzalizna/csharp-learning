// Metody / Методи
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
