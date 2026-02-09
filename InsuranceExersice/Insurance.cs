using System;
using System.Collections.Generic;

namespace InsuranceExample
{
    public class Insurance
    {
        private string species;
        private string name;
        private bool neutered;
        private double fee;

        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.species = animal.ToLower();
            this.name = name; 
            this.neutered = isNeutered;
            this.fee = payment;
        }

        public string GetNeuteredInfo()
        {
            return neutered ? "leikattu" : "leikkaamaton";
        }

        public override string ToString()
        {
            string capitalizedSpecies = char.ToUpper(species[0]) + species.Substring(1);
            return $"{capitalizedSpecies}: {name}, {GetNeuteredInfo()}";
        }

        public string Species => species;
        public string Name => name;
        public bool Neutered => neutered;
        public double Fee => fee;
    }
}
