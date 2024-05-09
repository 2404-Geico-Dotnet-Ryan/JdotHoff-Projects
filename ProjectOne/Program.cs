
using System;


class Program
{
    static void Main(string[] args)
    {
        Blood blood = new Blood();
        var assistant = new LabAssistant();
    }

    private static void SignIn(LabRepo lr)
    {

    }

    private static void MainMenuLab (LabRepo lr)
    {
        System.Console.WriteLine("Welcome!" + LabAssitant.Title );
        bool willContiue =true;
        while (willContiue)
        {
            System.Console.WriteLine("Please make a selection.");
            System.Console.WriteLine("*************************");
            System.Console.WriteLine("[1] Order Blood");
            System.Console.WriteLine("[2] Withdraw Blood");
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


     private static void MainMenuScien (LabRepo lr)
    {
        System.Console.WriteLine("Welcome!" + Scientist.Title );
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
                    OrderBlood(lr);
                    break;
                }
            case 2:
                {
                    WithdrawBlood(lr);
                    break;
                }
            case 3:
                {
                    OrderLabKits(lr);
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
        System.Console.WriteLine("Current Blood Count = " + BldUnits);
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

    private static bool DecideNextOptionL(LabRepo lr, int input)
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


