using FirmaDostawcza;

CentrumFloty centrum = new CentrumFloty();
centrum.Nazwa = "Express City";

Pojazd pojazd1 = new Pojazd();
pojazd1.IdPojazdu = "V-101";
pojazd1.Marka = "Ford";
pojazd1.Strefa = "Centrum";
pojazd1.KosztDnia = 180m;
pojazd1.CzyElektryczny = false;
pojazd1.LiczbaPaczekDzis = 24;

Pojazd pojazd2 = new Pojazd();
pojazd2.IdPojazdu = "V-102";
pojazd2.Marka = "Kross";
pojazd2.Strefa = "Centrum";
pojazd2.KosztDnia = 65m;
pojazd2.CzyElektryczny = true;
pojazd2.LiczbaPaczekDzis = 12;

Pojazd pojazd3 = new Pojazd();
pojazd3.IdPojazdu = "V-103";
pojazd3.Marka = "Renault";
pojazd3.Strefa = "Polnoc";
pojazd3.KosztDnia = 150m;
pojazd3.CzyElektryczny = false;
pojazd3.LiczbaPaczekDzis = 18;

centrum.DodajPojazd(pojazd1);
centrum.DodajPojazd(pojazd2);
centrum.DodajPojazd(pojazd3);

centrum.WypiszRaportyFloty();
Console.WriteLine($"Laczny koszt dnia: {centrum.PoliczLacznyKosztDnia()}");
Console.WriteLine($"Liczba pojazdow elektrycznych: {centrum.PoliczPojazdyElektryczne()}");
Console.WriteLine($"Laczna liczba paczek: {centrum.PoliczLacznaLiczbePaczek()}");

centrum.WypiszPojazdyDlaStrefy("Centrum");



