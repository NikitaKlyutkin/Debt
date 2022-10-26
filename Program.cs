using Debt;

    Debt1 mortgage = new Debt1(120000.0, 1.01);
    mortgage.PrintBalance();

    mortgage.WaitOneWaitOneYear();
    mortgage.PrintBalance();

    // Wait 20 years
    int years = 0;
    while (years < 20)
    {
        mortgage.WaitOneWaitOneYear();
        years = years + 1;
    }

    mortgage.PrintBalance();

