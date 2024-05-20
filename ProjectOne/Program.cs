
using System;
class Program
{

    //This program will allow Scientist and Lab Assitants to order or withdrawl blood and order lab kits depending upon their role. 
    //Scientists can order or withdrawl blood and order lab kits
    //Lab Assitants can order or withdrawl blood
    private static LabSytstemService labSytstemService = new LabSytstemService();
    private static LabRepo labRepo = new LabRepo();

    static void Main(string[] args)
    {
        // Users Service
        var usersService = new UserService();

        //First they want to log in to the application to see what they can do. 
        System.Console.WriteLine("_________________________");
        System.Console.WriteLine("     Lab Order Inc.      ");
        System.Console.WriteLine("_________________________");
        System.Console.WriteLine();
        System.Console.WriteLine("Please Login using your 3 digit login number.(no spaces)");
        System.Console.WriteLine();
        int userLogin = int.Parse(Console.ReadLine() ?? "0");
        System.Console.WriteLine("Please enter your first name.");

        string firstName = Console.ReadLine();
        User attemptedLoggedInUser = new User();
        attemptedLoggedInUser.UserLogin = userLogin;
        attemptedLoggedInUser.FirstName = firstName;

        User loggedInUser = usersService.Signin(attemptedLoggedInUser.UserLogin, attemptedLoggedInUser.FirstName);


        if (loggedInUser != null && loggedInUser.UserLogin == 123)
        {
            System.Console.WriteLine("Your login was successful!");

            MainMenuScientist();

            // #ERROR this method takes a labrepo has a parameter
            //MainMenuScientist(labRepo);
        }
        else if (loggedInUser != null && loggedInUser.UserLogin == 456)//
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
    static void MainMenuLab()
    {

        System.Console.WriteLine("Welcome! ");
        bool willContiue = true;
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

            willContiue = DecideNextOptionL(input);
        }
    }

    private static bool DecideNextOptionL(int input)
    {
     switch (input)
        {
            case 1:
                {
                    OrderBloodMenu();
                    break;
                }
            case 2:
                {
                    WithdrawBloodMenu();
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

    static int ValidationCmd(int input, int v)
    {
        if (input == 0 || input == 1 || input == 2)
        {
            return input;
        }

        // wont work if 0 is valid but must return an int
        return 0;

    }

   


    static void MainMenuScientist()
    {
        System.Console.WriteLine("Welcome! ");
        bool willContiue = true;
        while (willContiue)
        {
            System.Console.WriteLine("Please make a selection.");
            System.Console.WriteLine("*************************");
            System.Console.WriteLine("[1] Order Blood");
            System.Console.WriteLine("[2] Withdraw Blood");
            System.Console.WriteLine("[3] Order Lab Kits");
            System.Console.WriteLine("[0] Exit");
            System.Console.WriteLine("*************************");
            int input = int.Parse(Console.ReadLine() ?? "");
             //input = ValidationCmd(input, 3);

             willContiue = DecideNextOptionS(input);
        }
    }

static bool DecideNextOptionS(int input)
{

    switch (input)
    {
        case 1:
            {
                OrderBloodMenu();
                break;
            }
        case 2:
            {
                WithdrawBloodMenu();
                break;
            }
        case 3:
            {
                LabKitsMenu();
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


 static void OrderBloodMenu()
{
    System.Console.WriteLine("Current Blood Count = " + labSytstemService.RetrieveCurrentBloodCount());
    bool willContiue = true;
    while (willContiue)
    {
        System.Console.WriteLine("How many units of blood do you want to order?");
        System.Console.WriteLine("[1] 50 Units");
        System.Console.WriteLine("[2] 100 Units");

        int input = int.Parse(Console.ReadLine() ?? "0");
        // input = ValidationCmd(input, 2);

        willContiue = DecideNextOptionOB(input);
    }
}

    private static bool DecideNextOptionOB(int input)
    {

        switch (input)
        {
            case 1:
                {
                    labRepo.Add50();
                    break;
                }
            case 2:
                {
                    labRepo.Add100();
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



private static void WithdrawBloodMenu()
{
    System.Console.WriteLine("Current Blood Count = " + labSytstemService.RetrieveCurrentBloodCount());
    bool willContiue = true;
    while (willContiue)
    {
        System.Console.WriteLine("How many units of blood do you want to withdrawl?");
        System.Console.WriteLine("[1] 50 Units");
        System.Console.WriteLine("[2] 100 Units");

        int input = int.Parse(Console.ReadLine() ?? "0");
        // input = ValidationCmd(input, 2);

       // willContiue = DecideNextOptionWB(input);
    }
}

    private static bool DecideNextOptionWB(LabRepo lr, int input)
    {

        switch (input)
        {
            case 1:
                {
                    labRepo.Sub50();
                    break;
                }
            case 2:
                {
                    labRepo.Sub100();
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


private static void LabKitsMenu ()
{
    System.Console.WriteLine("Current Lab Kit Count = " + labSytstemService.RetrieveCurrentLabKitCount());
    bool willContiue =true;
    while (willContiue)
    {
        System.Console.WriteLine("How many Lab Kits do you want to order?");
        System.Console.WriteLine("[1] 10 Units");
        System.Console.WriteLine("[2] 20 Units");

        int input = int.Parse(Console.ReadLine() ?? "0");
        input = ValidationCmd(input, 2);

        // willContiue = DecideNextOptionLK(lr, input);
    }
}

    private static bool LabKitsMenu(LabRepo lr, int input)
    {

        switch (input)
        {
            case 1:
                {
                    labRepo.Add10();
                    break;
                }
            case 2:
                {
                    labRepo.Add20();
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


