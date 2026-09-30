using System;

class BankAccount
{
    // Encapsulation means keeping data and methods together
    // inside a class and controlling direct access to the data.

    // 'private' prevents outside classes from directly
    // modifying the balance.

    private double balance;

    // This method provides controlled access to
    // increase the account balance.

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;

            Console.WriteLine("Amount deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }

    // This method provides controlled access to
    // read the balance.

    public double GetBalance()
    {
        return balance;
    }
}

class Encapsulation
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(5000);

        Console.WriteLine("Current Balance: " +
                          account.GetBalance());

        // Direct access is not allowed because
        // balance is declared as private.

        // account.balance = 10000;  // ERROR
    }
}