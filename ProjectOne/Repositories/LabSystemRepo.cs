class LabRepo
{
    // //This class is in the Data Access / Repository Layer of our application.
    // So it solely responsible for any data access and management centered
    // around our  Object.
    LabRepo labRepo = new();
    UserStorage userStorage = new UserStorage();
    LabSystemStorage labSystemStorage = new LabSystemStorage();

    //Input is the their login number
    //return the persons Name and Title
    public void UserLogin()
    {
        if (userStorage.users.ContainsKey(id))
        {
            return userStorage.users[id];
        }
        /* We will let user know the passed in PetId was invalid/not found */
        else
        {
            Console.WriteLine("Login was not found, please try again.");
            Console.WriteLine();
            return null;
        }


        public void OrderBlood()
        {
            throw new NotImplementedException();
        }

        public void WithdrawlBlood()
        {
            throw new NotImplementedException();
        }

        public void OrderLabKits()
        {
            throw new NotImplementedException();

        }
    }
}    