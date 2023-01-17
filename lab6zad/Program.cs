// See https://aka.ms/new-console-template for more information

using lab6zad;

Mag bohater1 = new Mag();

Mag bohater4 = new Mag("Nikodemus", 99, 6, 12);

Wojownik bohater2 = new Wojownik();

Wojownik bohater3 = new Wojownik("Zbyszko", 100, 18);
bohater3.ZmienZywotnosc(-96);

Druzyna druzyna1 = new Druzyna("Druzyna_Pierscienia");
druzyna1.DodajPostac(bohater1);
druzyna1.DodajPostac(bohater2);
druzyna1.DodajPostac(bohater3);
druzyna1.DodajPostac(bohater4);
Console.WriteLine(druzyna1.ToString());