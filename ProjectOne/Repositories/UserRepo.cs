

using System.Data.SqlClient;

public class UserRepo
{

 private readonly string _connectionString;

    //Dependency Injection -> Constructor Injection
    public UserRepo(string connString)
    {
        _connectionString = connString;
    }

   
 
    //add, get-one, get-all, update, delete
    public User? GetUser(int id)
    {
        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.[User] WHERE Id = @Id";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);

            //Execute the Query
            using var reader = cmd.ExecuteReader();

            //Extract the Results
            if (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                User newUser = BuildUser(reader);
                return newUser;
            }

            return null; //Didnt find anyone :(

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
            return null;
        }
           
        
        // Alternative approach that breaks each step down.
        // if (userStorage.users.ContainsKey(id)) //if the user exists
        // {
        //     User selectedUser = userStorage.users[id]; //select the user
        //     return selectedUser; //return the user
        //     // return UserStorage.Users[id];
        // }
        // else
        // {
        //     System.Console.WriteLine("Invalid User ID - Please Try Again");
        //     return null;
        // }
    }

    public List<User> GetAllUsers()
    {
        List<User> users = new List<User>();

        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.[User]";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            //Execute the Query
            using var reader = cmd.ExecuteReader(); //flexing options here with the use of var.

            //Extract the Results
            while (reader.Read())
             {
                //for each iteration -> extract the results to a User object -> add to list.
                User newUser = BuildUser(reader);

                //don't return! Instead Add to List!
                users.Add(newUser);
            }

            return users;
        }
         catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }

        // foreach(var item in userStorage.users)
        // {
        //     users.Add(item.Value);
        // }

        // return users;
    }

        //Helper Method
    private static User BuildUser(SqlDataReader reader)
    {
        User newUser = new();
        newUser.UserId = (int)reader["Id"];
        newUser.UserLogin = (int)reader["UserLogin"];
        newUser.UserTitle = (string)reader["Title"];
        newUser.FirstName = (string)reader["FirstName"];
        newUser.LastName = (string)reader["LastName"];

        return newUser;
    }

   

}