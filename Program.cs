using System;

public class cardHolder {
  string cardNum;
  int pin;
  string firstName;
  string lastName;
  double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string  getCardNum() {
      return cardNum;
    }
 public int  getPin() {
      return pin;
    }
 public string  getFirstName() {
      return firstName;
    }
 public string  getLastName() {
      return lastName;
    }
 public double getBalance() {
      return balance;
    }

 public void setNum(string newCardNum){
   cardNum =newCardNum;
 }
  public void setPin(int newPin) {
       pin =newPin;
  }
public void setFirstName(string  newFirstName) {
       firstName =newFirstName;
  }
public void setLastName(string newLastName) {
       lastName=newLastName;
  }
  public void setBalance(double newBalance) {
       balance=newBalance;
  }
    static void Main (String[] args) {
       void printOptions() {
         Console.WriteLine("please choose from one of the following options...");
         Console.WriteLine("1.Show Balance");
         Console.WriteLine("2.Withdraw");
         Console.WriteLine("3.Deposit");
          Console.WriteLine("4.Exist");

       }
       void deposit(cardHolder currentUser) {
        
         Console.WriteLine("How much Birr would you like to deposit?");
         double deposit  = Double.Parse(Console.ReadLine());
         currentUser.setBalance( currentUser.getBalance() + deposit );
         Console.WriteLine("Thank you for deposit: your new balance is:" + currentUser.getBalance() );
       }

       void Withdraw(cardHolder currentUser) {

         Console.WriteLine("How much would you like withdraw ?");
         double withdraw=Double.Parse(Console.ReadLine());
         //check the user has enough money
         if(currentUser.getBalance() < withdraw ) {
            Console.WriteLine("Insufficient balance: ");
         } 
         else {
            currentUser.setBalance(currentUser.getBalance() -withdraw);
            Console.WriteLine(" Thanks you Usage : your current balance is " + currentUser.getBalance());
         }
       }
       void balance(cardHolder currentUser) {
           Console.WriteLine(" your current balance is: " + currentUser.getBalance());
       }
       List<cardHolder> cardHolders=new List<cardHolder>();
         cardHolders.Add(new cardHolder("123456",1234,"john","Girma", 1500));
         cardHolders.Add(new cardHolder("12345623",4321,"Abebe","Alemu", 2000));
          cardHolders.Add(new cardHolder("12345645",9999,"Assefa","Yheys", 3400));
         cardHolders.Add(new cardHolder("12345656",3333,"Tizazu","Assefa", 7000));
        cardHolders.Add(new cardHolder("12345678",4444,"Kebede","Girma", 4000));
     // user interaction
     Console.WriteLine("Welcome to Simple ATM");
     Console.WriteLine("please insert your debit card");
     string debitCardNum ="";
     cardHolder currentUser;

        while(true) {
         try
         {
              debitCardNum = Console.ReadLine();
              currentUser =cardHolders.FirstOrDefault(a=>a.cardNum==debitCardNum);
              if(currentUser !=null) {break;}
              else {Console.WriteLine("Card not recognized. please try again");}
 
         }
         catch {Console.WriteLine("Card not recognized please try again");}

        } 
        Console.WriteLine("please enter your pin");
        int userPin =0;
        while(true) {
         try
         {
            userPin =int.Parse(Console.ReadLine());
            if(currentUser.getPin() == userPin) {break;}
            else {Console.WriteLine("Incorrect pin. please try again");}
             
         }
         catch  { Console.WriteLine("Incorrect pin . try again"); }
        }

           Console.WriteLine("wellcome "+ currentUser.getFirstName() + " " + currentUser.getLastName() + " :");
           int option =0;
           do {
                printOptions();
                  try  {
                     option =int.Parse(Console.ReadLine());
                  }
                  catch {}
                  if(option ==1) {balance(currentUser);}
                  else if (option ==2) {Withdraw(currentUser);}
                  else if(option ==3) {deposit(currentUser);}
                  else if (option ==4) {break;}  
                  else {option =0;}
                  Console.WriteLine("Select your options...");
           } 
           while(option !=4);
           Console.WriteLine("Thank you: Have a nice day!");
        }
 }



