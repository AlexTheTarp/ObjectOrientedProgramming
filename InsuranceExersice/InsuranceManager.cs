using InsuranceExample;

public class InsuranceManager
{
    private List<Insurance> insurances = new List<Insurance>();

    public void AddInsurance(string animal, string name, bool isNeutered)
    {
        double fee = GetFee(animal, isNeutered);
        var insurance = new Insurance(animal, name, isNeutered, fee);
        insurances.Add(insurance);
    }
    
    public double GetFee(string species, bool isNeutered)
    {
        string animal = species.ToLower();

        if (animal == "koira")
        {
            return isNeutered? 50 : 80;
        }
        else if (animal == "kissa")
        {
            return isNeutered ? 40 : 60;
        }
        else
        {
            return 0;
        }
    }

    public void PrintInsurances()
    {
        Console.WriteLine($"vakuutuksia yhteensä {insurances.Count}");
        Console.WriteLine("vakuutukset: ");

        insurances.ForEach(insurance =>
        {
            Console.WriteLine($"{insurance}");
        });
    }

    public void FindInsurances(string species, bool isNeutered)
    {
        var matches = insurances.FindAll(i =>
            i.Species.Equals(species, StringComparison.OrdinalIgnoreCase) &&
            i.Neutered == isNeutered
        );

        matches.Reverse();

        if (matches.Count > 0)
        {
            Console.WriteLine("löytyi: ");
            foreach (var insurance in matches)
            {
                string capitalized = char.ToUpper(insurance.Species[0]) + insurance.Species.Substring(1);
                Console.WriteLine($"{capitalized}: {insurance.Name}, vakuutusmaksu {insurance.Fee} €");
            }
        }
    }
}
