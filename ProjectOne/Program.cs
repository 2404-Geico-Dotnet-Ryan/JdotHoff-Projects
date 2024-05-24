
using System;
class Program
{

    //This program will allow Scientist and Lab Assitants to order or withdrawl blood and order lab kits depending upon their role. 
    //Scientists can order or withdrawl blood and order lab kits
    //Lab Assitants can order or withdrawl blood
    private static LabSytstemService labSytstemService = null;
    public static LabRepo labRepo = null;

    static UserService us;
    static User? currentUser = null;

    static void Main(string[] args)
     {
        //Strings with an @ in front will provide you additional flexibility when creating strings.
        string path = @"C:\\Users\\U1J447\\Revature\\Practice\\JdotHoff-Projects\\JdotHoff-ProjectDB.txt";
       
        string connectionString = File.ReadAllText(path);
        us = new(connectionString);

        //LabRepo lr = new(); // <-- we'll need to add the connection string in the near future
        labSytstemService = new LabSytstemService(connectionString);
        labRepo = new LabRepo(connectionString);

        InitMenu(connectionString);

        //Lets just quickly test the Repo all by itself - and then if it works
        //we can assume nothing else changed -> therefore it should integrate cleanly into the app.

        // User newUser = new(0, "brian", "pass4", "user");
        // System.Console.WriteLine("Add User: " + ur.AddUser(newUser));

        //Test Get 1, Update and Delete.
        // User u = ur.GetUser(13) ?? new();
        // System.Console.WriteLine("Get User: " + u);
        // u.Password += "000";
        // System.Console.WriteLine("Updated User: " + ur.UpdateUser(u));
        // System.Console.WriteLine("Deleted User: " + ur.DeleteUser(u));


        // InitMenu();
    }
     private static void InitMenu(string connectionString)
    {
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

          // // Users Service

        var usersService = new UserService(connectionString);

        User loggedInUser = usersService.Signin(attemptedLoggedInUser.UserLogin, attemptedLoggedInUser.FirstName);


        if (loggedInUser != null && loggedInUser.UserLogin == 123)
        {
            System.Console.WriteLine("Your login was successful!");

            MainMenuScientist(connectionString);

            // #ERROR this method takes a labrepo has a parameter
            //MainMenuScientist(labRepo);
        }
        else if (loggedInUser != null && loggedInUser.UserLogin == 456)//
        {
            System.Console.WriteLine("Your login was successful!");

            MainMenuLab(connectionString);
        }
        else
        {
            System.Console.WriteLine("Login failed. Please try again.");
        }
    }


    //This is the menu for the Lab Assistants
    static void MainMenuLab(string connectionString)
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

            willContiue = DecideNextOptionL(input, connectionString);
        }
    }

    private static bool DecideNextOptionL(int input, string connectionString)
    {
     switch (input)
        {
            case 1:
                {
                    OrderBloodMenu(connectionString);
                    break;
                }
            case 2:
                {
                    WithdrawBloodMenu(connectionString);
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

   


    static void MainMenuScientist(string connectionString)
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
            //  input = ValidationCmd(input, 3);

             willContiue = DecideNextOptionS(input, connectionString);
        }
    }

static bool DecideNextOptionS(int input, string connectionString)
{

    switch (input)
    {
        case 1:
            {
                OrderBloodMenu(connectionString);
                break;
            }
        case 2:
            {
                WithdrawBloodMenu(connectionString);
                break;
            }
        case 3:
            {
                LabKitsMenu(connectionString);
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


 static void OrderBloodMenu(string connectionString)
{
    System.Console.WriteLine("Current Blood Count = " + labRepo.RetrieveBloodCount(connectionString));
    bool willContiue = true;
    while (willContiue)
    {
        System.Console.WriteLine("How many units of blood do you want to order?");
        System.Console.WriteLine("[1] 50 Units");
        System.Console.WriteLine("[2] 100 Units");
        System.Console.WriteLine("[0] Exit");

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



private static void WithdrawBloodMenu(string connectionString)
{
    System.Console.WriteLine("Current Blood Count = " + labRepo.RetrieveBloodCount(connectionString));
    bool willContiue = true;
    while (willContiue)
    {
        System.Console.WriteLine("How many units of blood do you want to withdrawl?");
        System.Console.WriteLine("[1] 50 Units");
        System.Console.WriteLine("[2] 100 Units");
        System.Console.WriteLine("[0] Exit");

        int input = int.Parse(Console.ReadLine() ?? "0");
        // input = ValidationCmd(input, 2);

       willContiue = DecideNextOptionWB(input);
    }
}

    private static bool DecideNextOptionWB(int input)
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


private static void LabKitsMenu(string connectionString)
{
    System.Console.WriteLine("Current Lab Kit Count = " + labRepo.RetrieveLabKitCount(connectionString));
    bool willContiue =true;
    while (willContiue)
    {
        System.Console.WriteLine("How many Lab Kits do you want to order?");
        System.Console.WriteLine("[1] 10 Units");
        System.Console.WriteLine("[2] 20 Units");
        System.Console.WriteLine("[0] Exit");

        int input = int.Parse(Console.ReadLine() ?? "0");
        input = ValidationCmd(input, 2);

        willContiue = LabKitsMenu(input);
    }
}

    private static bool LabKitsMenu(int input)
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


