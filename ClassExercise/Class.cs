namespace CompanyExercise
{
    class Company
    {
        private string title;
        private string address;
        private string phone;
        public double outcome;
        private double expense;

        public Company()
        {
            title = "Unknown Company";
            address = "Unknown Adress";
            phone = "N/A";
            outcome = 0.0;
            expense = 0.0;
        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public Company(Company other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other), "Cannot copy from null object.");
            }

            this.title = other.title;
            this.address = other.address;
            this.phone = other.phone;
            this.outcome = other.outcome;
            this.expense = other.expense;
        }

        public string GetFinancialStatus()
        {
            if (outcome <= 0)
            {
                return $"{title}: No outcome recorded → cannot calculate profit percentage.";
            }

            double profitPercentage = ((outcome - expense) / outcome) * 100;

            string evaluation;

            if (profitPercentage < 5)
            {
                evaluation = "The company is doing poorly.";
            }
            else if (profitPercentage < 10)
            {
                evaluation = "The company is doing moderately.";
            }
            else if (profitPercentage < 20)
            {
                evaluation = "The company is doing satisfactorily.";
            }
            else
            {
                evaluation = "The company is doing well.";
            }

            return $"{title} (Address: {address}, Phone: {phone})\n" +
               $"outcome: {outcome:C}, Expenses: {expense:C}\n" +
               $"Profit percentage: {profitPercentage:F2}%\n" +
               $"Evaluation: {evaluation}";
        }
        public override string ToString()
        {
            return $"{title} – {address} – Phone: {phone}";
        }
    }
}