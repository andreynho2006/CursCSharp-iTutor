using System;

namespace Tema4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal("cat", "red", 4);
            Animal dog = new Animal("dog", "brown");
            Animal horse = new Animal("horse");

            dog.varsta = 3;

            horse.culoare = "brown";
            horse.varsta = 7;

            Console.WriteLine($"Animal {cat.tipAnimal} is {cat.culoare} and has {cat.varsta} years.");
            Console.WriteLine($"Animal {dog.tipAnimal} is {dog.culoare} and has {dog.varsta} years.");
            Console.WriteLine($"Animal {horse.tipAnimal} is {horse.culoare} and has {horse.varsta} years.");

            Imobil apartament = new Imobil("apartament", 1, 400000.00);
            Imobil casa = new Imobil("casa", 3);
            Imobil vila = new Imobil("vila");

            casa.pret = 345000.00;

            vila.nrEtaje = 2;
            vila.pret = 79000.00;

            Console.WriteLine($"Imobilul tip {apartament.tipCasa} are {apartament.nrEtaje} etaje si un pret de {apartament.pret} lei.");
            Console.WriteLine($"Imobilul tip {casa.tipCasa} are {casa.nrEtaje} etaje si un pret de {casa.pret} lei.");
            Console.WriteLine($"Imobilul tip {vila.tipCasa} are {vila.nrEtaje} etaje si un pret de {vila.pret} lei.");
        }
    }
}
