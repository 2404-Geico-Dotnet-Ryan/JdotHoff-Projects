using System;
using System.Collections;

public class UserRepo
{


    UserStorage userStorage = new();

    //add, get-one, get-all, update, delete


    

    public User? GetUser(int id)
    {
        // Alternative approach that breaks each step down.
        if (userStorage.users.ContainsKey(id)) //if the user exists
        {
            User selectedUser = userStorage.users[id]; //select the user
            return selectedUser; //return the user
            // return UserStorage.Users[id];
        }
        else
        {
            System.Console.WriteLine("Invalid User ID - Please Try Again");
            return null;
        }
    }

    public List<User> GetAllUsers()
    {
        List<User> users = new List<User>();
        foreach(var item in userStorage.users)
        {
            users.Add(item.Value);
        }

        return users;
    }

   

}