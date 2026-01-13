namespace CompanyExercise
{
    class Company
    {
        private string title;
        private string address;
        private string phone;
        private double income;
        private double expence;

        public Company()
        {
            title = "Unknown Company";
            address = "Unknown Adress";
            phone = "N/A";
            income = 0.0;
            expence = 0.0;
        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expence = expence;
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
            this.income = other.income;
            this.expence = other.expence;
        }

        public string GetFinancialStatus()
        {
            if (income <= 0)
            {
                return $"{title}: No income recorded → cannot calculate profit percentage.";
            }

            double profitPercentage = ((income - expence) / income) * 100;

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
               $"Income: {income:C}, Expenses: {expence:C}\n" +
               $"Profit percentage: {profitPercentage:F2}%\n" +
               $"Evaluation: {evaluation}";
        }
        public override string ToString()
        {
            return $"{title} – {address} – Phone: {phone}";
        }
    }
}