static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance >= 0  && balance < 1000 ? 0.5f:  balance >=1000 && balance < 5000 ?  1.621f : balance >= 5000 ? 2.475f: 3.213f;

    public static decimal Interest(decimal balance) => ((decimal)InterestRate(balance) / 100.0m) * balance;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);


    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
    int year = 0;
    while (targetBalance > balance)
    {
        balance += Interest(balance);
        year++;    
    }   
    return year;
    }
}
