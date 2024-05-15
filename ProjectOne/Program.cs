
using System;
class Program
{

    //This program will allow Scientist and Lab Assitants to order or withdrawl blood and order lab kits depending upon their role. 
    //Scientists can order or withdrawl blood and order lab kits
    //Lab Assitants can order or withdrawl blood


    static void Main(string[] args)
    {

 
        LabRepo labRepo = new LabRepo();
        MainMenuLab(labRepo);
    }

    public static int SignIn(LabRepo lr)
    {
//First they want to log in to the application to see what they can do. 
        System.Console.WriteLine("_________________________");
        System.Console.WriteLine("     Lab Order Inc.      ");
        System.Console.WriteLine("_________________________");
        System.Console.WriteLine();
        System.Console.WriteLine("Please Login using your 3 digit login number.(no spaces)");
        System.Console.WriteLine();
        int input = int.Parse(Console.ReadLine() ?? "0");
        System.Console.WriteLine("Please enter your first name.");
        string FirstName = int.Parse(Console.ReadLine() ?? "");
        User? loggedInUser = loggedInUser (UserLogin, FirstName);
        if ((loggedInUser != null) + UserLogin = 123)
        {
            System.Console.WriteLine("Your login was successful!");

            MainMenuScientist();
        }
        else if ((loggedInUser != null) + UserLogin = 456)
        {
            System.Console.WriteLine("Your login was successful!");

           MainMenuLab();
        }
        else
        {
            System.Console.WriteLine("Login failed. Please try again.");
        }
    }





//This is the menu for the Lab Assistants
    private static void MainMenuLab (LabRepo lr)
    {
        System.Console.WriteLine("Welcome! " + user.usertitle + User.FirstName + User.LastName);
        bool willContiue =true;
        while (willContiue)
        {
            System.Console.WriteLine("Please make a selection.");
            System.Console.WriteLine("*************************");
            System.Console.WriteLine("[1] Order Blood");
            System.Console.WriteLine("[2] Withdrawl Blood");
            System.Console.WriteLine("[0] Exit");
            System.Console.WriteLine("*************************");

            int input = int.Parse(Console.ReadLine() ?? "0");
            input = ValidationCmd(input, 2);

            willContiue = DecideNextOptionL(lr, input);
        }
    }

    private static bool DecideNextOptionL(LabRepo lr, int input)
    {
        
        switch (input)
        {
            case 1:
                {
                    OrderBlood(lr);
                    break;
                }
            case 2:
                {
                    WithdrawlBlood(lr);
                    break;
                }
            case 0:
            default:
                {
                    return false;
                }
        }

        return true;
    }


     private static void MainMenuScientist (LabRepo lr)
    {
        System.Console.WriteLine("Welcome! " + Scientist.Title );
        bool willContiue =true;
        while (willContiue)
        {
            System.Console.WriteLine("Please make a selection.");
            System.Console.WriteLine("*************************");
            System.Console.WriteLine("[1] Order Blood");
            System.Console.WriteLine("[2] Withdraw Blood");
            System.Console.WriteLine("[3] Order Lab Kits");
            System.Console.WriteLine("[0] Exit");
            System.Console.WriteLine("*************************");

            int input = int.Parse(Console.ReadLine() ?? "0");
            input = ValidationCmd(input, 3);

            willContiue = DecideNextOptionS(lr, input);
        }
    }

    
    private static bool DecideNextOptionS(LabRepo lr, int input)
    {
        
        switch (input)
        {
            case 1:
                {
                    OrderBloodMenu(lr);
                    break;
                }
            case 2:
                {
                    WithdrawBloodMenu(lr);
                    break;
                }
            case 3:
                {
                    LabKitsMenu(lr);
                    break;
                }
           
            case 0:
            default:
                {
                    return false;
                }
        }

        return true;
    }

    
 private static void OrderBloodMenu (LabRepo lr)
    {
        System.Console.WriteLine("Current Blood Count = " + CurrentCount);
        bool willContiue =true;
        while (willContiue)
        {
            System.Console.WriteLine("How many units of blood do you want to order?");
            System.Console.WriteLine("[1] 50 Units");
            System.Console.WriteLine("[2] 100 Units");
            
            int input = int.Parse(Console.ReadLine() ?? "0");
            input = ValidationCmd(input, 2);

            willContiue = DecideNextOptionOB(lr, input);
        }
    }

    private static bool DecideNextOptionOB(LabRepo lr, int input)
    {
        
        switch (input)
        {
            case 1:
                {
                    Add50(lr);
                    break;
                }
            case 2:
                {
                    Add100(lr);
                    break;
                }
            case 0:
            default:
                {
                    return false;
                }
        }

        return true;
    }



private static void WithdrawBloodMenu (LabRepo lr)
    {
        System.Console.WriteLine("Current Blood Count = " + BldUnits);
        bool willContiue =true;
        while (willContiue)
        {
            System.Console.WriteLine("How many units of blood do you want to withdrawl?");
            System.Console.WriteLine("[1] 50 Units");
            System.Console.WriteLine("[2] 100 Units");
            
            int input = int.Parse(Console.ReadLine() ?? "0");
            input = ValidationCmd(input, 2);

            willContiue = DecideNextOptionWB(lr, input);
        }
    }

    private static bool DecideNextOptionWB(LabRepo lr, int input)
    {
        
        switch (input)
        {
            case 1:
                {
                    Sub50(lr);
                    break;
                }
            case 2:
                {
                    Sub100(lr);
                    break;
                }
            case 0:
            default:
                {
                    return false;
                }
        }

        return true;
    }


    private static void LabKitsMenu (LabRepo lr)
    {
        System.Console.WriteLine("Current Lab Kit Count = " + Units);
        bool willContiue =true;
        while (willContiue)
        {
            System.Console.WriteLine("How many Lab Kits do you want to order?");
            System.Console.WriteLine("[1] 10 Units");
            System.Console.WriteLine("[2] 20 Units");
            
            int input = int.Parse(Console.ReadLine() ?? "0");
            input = ValidationCmd(input, 2);

            willContiue = DecideNextOptionLK(lr, input);
        }
    }

    private static bool LabKitsMenu(LabRepo lr, int input)
    {
        
        switch (input)
        {
            case 1:
                {
                    Add10(lr);
                    break;
                }
            case 2:
                {
                    Add20(lr);
                    break;
                }
            case 0:
            default:
                {
                    return false;
                }
        }

        return true;
    }

}


