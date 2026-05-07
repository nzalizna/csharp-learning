using System;
using System.Collections.Generic;
using System.Text;

namespace FirmaDostawcza;
    public class Pojazd
{

    public string IdPojazdu {  get; set; }
        public string Marka {  get; set; }
        public string Strefa {  get; set; }
        public decimal KosztDnia {  get; set; }
        public bool CzyElektryczny {  get; set; }
        public int LiczbaPaczekDzis {  get; set; }

    public void WypiszInformacje()
    {
        Console.WriteLine ("Id: " + IdPojazdu);
        Console.WriteLine("Marka: " + Marka);
        Console.WriteLine("Strefa: " + Strefa);
        Console.WriteLine("Koszt dnia: " + KosztDnia);
        Console.WriteLine("Elektryczny: " + CzyElektryczny);
        Console.WriteLine("Paczki dzis: " + LiczbaPaczekDzis);
    }

    public bool CzyObslugujeDuzyRuch()
    {
        return LiczbaPaczekDzis > 20;
    }

}

