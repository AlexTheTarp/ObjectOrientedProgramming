using InsuranceExample;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Tämä on tässä koska muuten euro mekrkit näkyvät kysymys merkkeinä.

        InsuranceManager im = new InsuranceManager();

        im.AddInsurance("koira", "Rolle", false);
        im.AddInsurance("koira", "Tessu", true);
        im.AddInsurance("kissa", "Monni", true);
        im.AddInsurance("koira", "Pluto", false);
        im.AddInsurance("lintu", "Tipi", false);

        im.PrintInsurances();

        Console.WriteLine("---");

        im.FindInsurances("koira", false);
    }
}
