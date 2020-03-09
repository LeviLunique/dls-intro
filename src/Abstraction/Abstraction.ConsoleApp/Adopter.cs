using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.ConsoleApp
{
    public class Adopter : IAdopter
    {
        private int _adopterAge;
        public bool pass { get; private set; }

        public Adopter(int age)
        {
            _adopterAge = age;
        }

        private bool IsYoung => _adopterAge < 21;

        public void AgeCriterion()
        {
            if (IsYoung)
            {
                this.pass = false;
                Console.WriteLine("Sorry, only people aged 21 and over can adopt a dog. Maybe later!");
            }
            else
            {
                this.pass = true;
                Console.WriteLine("Congratulations, you adopted a dog!!!!!");

            }
        }
    }
}
