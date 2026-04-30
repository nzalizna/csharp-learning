Console.WriteLine("Podaj liczbę zdobytych punktów:");
double zdobytePkt = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj maksymalną liczbę punktów:");
int maksLiczbaPkt = int.Parse(Console.ReadLine());

double wynikProc = (zdobytePkt / maksLiczbaPkt) * 100;
wynikProc = Math.Round(wynikProc, 2);

double ocena;
if (wynikProc < 50)
{
    ocena = 2.0;
}
else if (wynikProc < 60)
{
    ocena = 3.0;
}
else if (wynikProc < 70)
{
    ocena = 3.5;
}
else if (wynikProc < 80)
{
    ocena = 4.0;
}
else if (wynikProc < 90)
{
    ocena = 4.5;
}
else
{
    ocena = 5.0;
}

Console.WriteLine("Ocena koncowa: " + ocena + " (" + wynikProc + "%)");
Console.ReadLine();