namespace Spotkanie3;

public class Student
{
    // Dane / Дані -- що описує студента
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Email { get; set; }
    public double[] Oceny { get; set; }


// Zachowanie / Поведінка -- що студент вміє робити
public void PrzedstawSie()
    {
        Console.WriteLine(Imie);
        Console.WriteLine(Nazwisko);
    }

    public double ObliczSrednia()
    {
        double suma = 0;
        foreach (double d in Oceny)
        {
            suma += d;
        }
        return suma / Oceny.Length;
    }
}