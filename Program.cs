using System;

public class cardHolder
{
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNumber, int pin, string firstName, string lastName, double balance)
    {
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNumber()
    {
        return cardNumber;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setPin(int newPin)
    {
        this.pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        this.firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        this.lastName = newLastName;
    }

    public  void setBalance(double newBalance)
    {
        this.balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options....");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit (cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());

            currentUser.setBalance(deposit + currentUser.getBalance());
            Console.WriteLine("Thank you for your $$. your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawl = Double.Parse(Console.ReadLine());

            if (currentUser.getBalance() > withdrawl)
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawl);
                Console.WriteLine("You're good to go! Thank you.");
            }

            else
            {
                Console.WriteLine("Sorry, Insufficient Balance");
            }


        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance is: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1234567890123456", 1234, "John", "Doe", 10000.0));
        cardHolders.Add(new cardHolder("9876543210987654", 5678, "Jane", "Smith", 500.0));
        cardHolders.Add(new cardHolder("1111222233334444", 9999, "Alice", "Johnson", 250.0));
        cardHolders.Add(new cardHolder("5555666677778888", 2468, "Bob", "Williams", 750.0));
        cardHolders.Add(new cardHolder("9999000011112222", 1357, "Sarah", "Davis", 15000.0));

        Console.WriteLine("Welcome to the ATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNum);
                if(currentUser != null)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }

            catch
            {
                Console.WriteLine("Card not recognized. Please try again")
            }
        }
    }
}