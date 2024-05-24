public class UserService
{
        UserRepo ur = null;

    public UserService(string connectionString)
    {
        this.ur = new UserRepo(connectionString);
    }

    //Register - this is not prompting the user for input, but rather taking in a User object.



    //Login below will not use the User object, but rather pass in the information needed to login.

    public User? Signin (int UserLogin, string FirstName)//; #ERROR no semicolon after a method declaration
    {   
    //This is where we would do some validation.
    //For example, we could check if the email is already in use.
    //We could also check if the password is strong enough
    //We could also check if the username is already in use.
    //We could also check if the email and password match.

    //What I will actually be doing is:
    //get all users
    //check if the username exists
    //if so they login -> return the user

    List<User> allUsers = ur.GetAllUsers();

        foreach (User user in allUsers)
        {
            if (user.UserLogin == UserLogin && user.FirstName == FirstName) //BOTH UserLogin and FirstName must match to login. the && is the AND operator and checks to make sure both sides are true.
            {
                return user;
            }

        }

        System.Console.WriteLine("Invalid Login or First Name");
        return null; //if the foreach loop completes and no user is found, then the user does not exist in the system.



    }
}