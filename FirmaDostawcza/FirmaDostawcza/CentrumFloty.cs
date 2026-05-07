using System;
using System.Collections.Generic;
using System.Text;

namespace FirmaDostawcza
{
    public class CentrumFloty
    {
        public string Nazwa { get; set; }
        private List<Pojazd> pojazdy = new List<Pojazd>();


        public void DodajPojazd(Pojazd pojazd)
        {
            pojazdy.Add(pojazd);
        }
        public void WypiszRaportyFloty()
        {
            foreach (Pojazd p in pojazdy)
            {
                p.WypiszInformacje();
            }
        }

        public decimal PoliczLacznyKosztDnia()
        {
            decimal suma = 0;
            foreach (Pojazd p in pojazdy)
            {
                suma += p.KosztDnia;
             }
            return suma;
            
        }
        
        public int PoliczLacznaLiczbePaczek()
        {
            int suma1 = 0;
            foreach (Pojazd p in pojazdy)
            {
                suma1 += p.LiczbaPaczekDzis;
            }
            return suma1;
        }
        public int PoliczPojazdyElektryczne()
        {
            int suma2 = 0;
       
                foreach (Pojazd p in pojazdy)
            {
                if (p.CzyElektryczny == true)
                {
                    suma2++;
                }
            }
                return (int) suma2;
        }

       public void  WypiszPojazdyDlaStrefy(string strefa)
        {
            foreach (Pojazd p in pojazdy)
            {
                if (p.Strefa == strefa)
                    {
                    p.WypiszInformacje();
                }

            }

        }

    }

    }

