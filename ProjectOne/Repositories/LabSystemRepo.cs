public class LabRepo
{
    // //This class is in the Data Access / Repository Layer of our application.
    // So it solely responsible for any data access and management centered
    // around our  Object.

    // #ERROR stackoverflow, cannot initialize an instance of itself within itself
    //LabRepo labRepo = new();
    UserStorage userStorage = new UserStorage();
    LabSystemStorage labSystemStorage = new LabSystemStorage();

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

    //     public void Add50()
    public int Add50();
    {
        if (labSystemStorage.RetrieveCurrentBloodCount() >= 0);
        {
            return (currentbloodcount + 50);
        }
    }

    public int Add100();
    {
        if (currentbloodcount >= 0);
        {
            return (currentbloodcount + 100);
        }
    }

    public void Sub50()
    {
        if (currentbloodcount >= 50);
        {
            return (currentbloodcount - 50);
        }
        else 
        {
            System.Console.WriteLine("There is not enough blood currently to withdrawl your selection.");
            System.Console.WriteLine("Please make another selection.");
        }
    }

    public void Sub100()
    {
        if(currentbloodcount >= 100);
        {
            return (currentbloodcount - 100);
        }
        else 
        {
            System.Console.WriteLine("There is not enough blood currently to withdrawl your selection.");
            System.Console.WriteLine("Please make another selection.");
        }
    }

    public void Add10()
    {
        return (CurrentLabkitCount + 10);
    }

    public void Add20()
    {
        return (CurrentLabkitCount + 20);
    }
}