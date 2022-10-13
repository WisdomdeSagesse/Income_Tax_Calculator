using System;
    class Program
    {
        static void Main()
        {
        const decimal basicTaxRate = 0.2m;
        const decimal higherTaxRate = 0.4m;
        const decimal additionalTaxRate = 0.45m;
        decimal baseIncomeTreshold = 37700;
        decimal higherIncomeTreshold = 150000;
        decimal income;
        decimal taxAmount;

        Console.Write("What is your income?  ");
        income = Convert.ToDecimal(Console.ReadLine());
        decimal personalAllowance = 12570;
        decimal personalAllowanceIncomeTreshold = 100000;

        
        if (income > 100000 && income <= 125140)
        {
            decimal allowanceReducationRate = 2;
            personalAllowance = ((personalAllowance - (income - personalAllowanceIncomeTreshold) / allowanceReducationRate));
        }
        else if (income > 125140)
        {
            personalAllowance = 0;
        }
        
        decimal taxableIncome = income - personalAllowance;
        
        if (taxableIncome <= baseIncomeTreshold)
        {
            taxAmount = taxableIncome * basicTaxRate;
        }
        else if ((income - baseIncomeTreshold) <= higherIncomeTreshold)
        {
            decimal baseTax = baseIncomeTreshold * basicTaxRate;
            decimal higherTax = higherTaxRate * (taxableIncome - baseIncomeTreshold);
            taxAmount = baseTax + higherTax;
        }
        else
        {
            decimal baseTax = baseIncomeTreshold * basicTaxRate;
            decimal higherTax = higherTaxRate * higherIncomeTreshold;
            decimal additionalTax = additionalTaxRate * (taxableIncome - baseIncomeTreshold - higherIncomeTreshold);
            taxAmount = baseTax + higherTax + additionalTax;
        }
        Console.WriteLine($"Your income is: {income}");
        Console.WriteLine($"Your personal allowance is: {personalAllowance}");
        Console.WriteLine($"Your taxable income is: {taxableIncome}");
        Console.WriteLine($"Your income tax is: {taxAmount}");

     
        }
    }
