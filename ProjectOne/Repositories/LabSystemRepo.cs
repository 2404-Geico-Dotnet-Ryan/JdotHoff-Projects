public class LabRepo
{
    // //This class is in the Data Access / Repository Layer of our application.
    // So it solely responsible for any data access and management centered
    // around our  Object.

    // #ERROR stackoverflow, cannot initialize an instance of itself within itself
    //LabRepo labRepo = new();
    UserStorage userStorage = new UserStorage();
    LabSystemStorage labSystemStorage = new LabSystemStorage();

    LabSytstemService labSystemService = new LabSytstemService();

    // close class brace, you comment it out below

    //Input is the their login number
    //return the persons Name and Title
    // public void UserLogin(int UserLogin)
    // {
    //     if (userStorage.users.ContainsKey(id))
    //     {
    //         return userStorage.users[id];
    //     }
    //     // We will let user know the login was invalid
    //     else
    //     {
    //         Console.WriteLine("Login was not found, please try again.");
    //         Console.WriteLine();
    //         return null;
    //     }
    // }

   
    public int Add50()//new method 
    {
        int bloodCount =  labSystemService.RetrieveCurrentBloodCount();//first we call to get the current bloodcount
        if (bloodCount >= 0)
        {
            labSystemService.AddBlood(50);
            return labSystemService.RetrieveCurrentBloodCount();
        }

        return 0;
    }

    public int Add100()
    {
       int bloodCount =  labSystemService.RetrieveCurrentBloodCount();
        if (bloodCount >= 0)
        {
            labSystemService.AddBlood(100);
            return labSystemService.RetrieveCurrentBloodCount();
        }
        return 0;
    }

    public int Sub50()
    {
         int bloodCount =  labSystemService.RetrieveCurrentBloodCount();
        if (bloodCount >= 50)
        {
            labSystemService.RemoveBlood(-50);
            return labSystemService.RetrieveCurrentBloodCount();
        }
        else 
        {
            System.Console.WriteLine("There is not enough blood currently to withdrawl your selection.");
            System.Console.WriteLine("Please make another selection.");
        }
        return 0;
    }

    public int Sub100()
    {
        int bloodCount =  labSystemService.RetrieveCurrentBloodCount();
        if(bloodCount >= 100)
        {
            labSystemService.RemoveBlood(-100);
            return labSystemService.RetrieveCurrentBloodCount();
        }
        else 
        {
            System.Console.WriteLine("There is not enough blood currently to withdrawl your selection.");
            System.Console.WriteLine("Please make another selection.");
        }
        return 0;
    }

    public int Add10()
    {
        int labKitCount =  labSystemService.RetrieveCurrentLabKitCount();
        if(labKitCount >= 0)
        {
            labSystemService.AddLabKits(10);
            return labSystemService.RetrieveCurrentLabKitCount();
        }
        return 0;
        
    }

    public int Add20()
    {
        int labKitCount =  labSystemService.RetrieveCurrentLabKitCount();
        if(labKitCount >= 0)
        {
            labSystemService.AddLabKits(20);
            return labSystemService.RetrieveCurrentLabKitCount();
        }
        return 0;
        
    }
}