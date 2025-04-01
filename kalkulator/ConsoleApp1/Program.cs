﻿Console.WriteLine("Wybierz działanie:");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
//wybranie dzialania
double odp;
while(!double.TryParse(Console.ReadLine(), out odp) && odp > 0 && odp < 5){
    Console.WriteLine("Podaj poprawną liczbę");
}

Console.WriteLine();
//wpisanie liczb do obliczenia
double a, b;
Console.Write("Podaj pierwszą liczbę: ");
while (!double.TryParse(Console.ReadLine(), out a)) {
    Console.Write("Podaj poprawną liczbę: ");
}
Console.WriteLine();
Console.Write("Podaj drugą liczbę: ");
while (!double.TryParse(Console.ReadLine(), out b)) {
    Console.Write("Podaj poprawną liczbę: ");
}

Console.WriteLine();
//wykonywanie dzialan
switch (odp){
    case 1:
        suma(a, b);
        break;
    case 2:
        roznica(a, b);
        break;
    case 3:
        iloczyn(a, b);
        break;
    case 4:
        iloraz(a, b);
        break;
}

void suma(double a, double b){
    Console.WriteLine($"Suma wynosi {a + b}.");
}

void roznica(double a, double b){
    Console.WriteLine($"Suma wynosi {a - b}.");
}

void iloczyn(double a, double b){
    Console.WriteLine($"Suma wynosi {a * b}.");
}

void iloraz(double a, double b){
    Console.WriteLine($"Suma wynosi {a / b}.");
}
