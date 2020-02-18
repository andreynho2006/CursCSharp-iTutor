using System;
namespace Tema4
{
    public class Animal
    {
        public Animal()
        {
            this.tipAnimal = "";
            this.culoare = "";
            this.varsta = 0;
        }

        public Animal(string tipAnimal)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = "";
            this.varsta = 0;
        }

        public Animal(string tipAnimal, string culoare)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = culoare;
            this.varsta = 0;
        }

        public Animal(string tipAnimal, string culoare, int varsta)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = culoare;
            this.varsta = varsta;
        }

        public string tipAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }
    }

    
}
