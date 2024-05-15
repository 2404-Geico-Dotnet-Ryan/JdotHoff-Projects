public class LabRepo
{
    // //This class is in the Data Access / Repository Layer of our application.
    // So it solely responsible for any data access and management centered
    // around our  Object.
    LabRepo labRepo = new();
    UserStorage userStorage = new UserStorage();
    LabSystemStorage labSystemStorage = new LabSystemStorage();

    //Input is the their login number
    //return the persons Name and Title
    public void UserLogin(int UserLogin)
    {
        if (userStorage.users.ContainsKey(id))
        {
            return userStorage.users[id];
        }
        // We will let user know the login was invalid
        else
        {
            Console.WriteLine("Login was not found, please try again.");
            Console.WriteLine();
            return null;
        }
    }

    public void Add50()
    {
        return (currentbloodcount + 50);
    }

    public void Add100()
    {
        return (currentbloodcount + 100);
    }

    public void Sub50()
    {
        if (currentbloodcount >= 50);
        {
            return (currentbloodcount - 50);
        }
        else if 
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
        else if
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