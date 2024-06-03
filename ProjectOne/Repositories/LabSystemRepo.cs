using System.Data.SqlClient;

public class LabRepo
{
    // //This class is in the Data Access / Repository Layer of our application.
    // So it solely responsible for any data access and management centered
    // around our  Object.

    // #ERROR stackoverflow, cannot initialize an instance of itself within itself
    //LabRepo labRepo = new();
   // UserStorage userStorage = new UserStorage();
    //LabSystemStorage labSystemStorage = new LabSystemStorage();
    string _connectionString;

    LabSytstemService labSystemService = null;
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


 //Dependency Injection -> Constructor Injection
    public LabRepo(string connectionString)
    {
        labSystemService = new LabSytstemService(connectionString);
        this._connectionString = connectionString;
    }

   
    public int Add50()//new method - access modifier-public, return type- int, method name-Add50, parameter is empty
    {
        int bloodCount =  RetrieveBloodCount(_connectionString);//first we call to get the current bloodcount
        if (bloodCount >= 0)//If condition
        {
            AddBlood(50); //statement for if condition
           Console.WriteLine("New Current Blood Count is =" + RetrieveBloodCount(_connectionString)); //statement for if condition
        }
        
        return 0;
    }

    public int Add100()
    {
       int bloodCount =  RetrieveBloodCount(_connectionString);
        if (bloodCount >= 0)
        {
            AddBlood(100);
            Console.WriteLine("New Current Blood Count is =" + RetrieveBloodCount(_connectionString)); 
        }
        return 0;
    }

    public int Sub50() //new method: access modifier-public, return type- int, method name-Sub50, parameter is empty
    {
         int bloodCount =  RetrieveBloodCount(_connectionString); //first we call to get the current bloodcount
        if (bloodCount >= 50)//If condition
        {
            UpdateBlood(bloodCount,-50);//statement for if condition
            Console.WriteLine("New Current Blood Count is =" + RetrieveBloodCount(_connectionString));//statement for if condition
        }
        else 
        {
            System.Console.WriteLine("There is not enough blood currently to withdrawl your selection.");//statement for other condition
            System.Console.WriteLine("Please make another selection.");//statement for other condition
        }
        return 0;
    }

    public int Sub100()
    {
        int bloodCount =  RetrieveBloodCount(_connectionString);
        if(bloodCount >= 100)
        {
            UpdateBlood(bloodCount, -100);
            Console.WriteLine("New Current Blood Count is =" + RetrieveBloodCount(_connectionString));
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
        int labKitCount =  RetrieveLabKitCount(this._connectionString);
        if(labKitCount >= 0)
        {
            AddLabKits(10);
            Console.WriteLine("Current LabKit Count =" + RetrieveLabKitCount(this._connectionString));
        }
        return RetrieveLabKitCount(this._connectionString);
        
    }

    public int Add20()
    {
        int labKitCount =  RetrieveLabKitCount(this._connectionString);
        if(labKitCount >= 0)
        {
            AddLabKits(20);
           Console.WriteLine("Current LabKit Count is =" + RetrieveLabKitCount(this._connectionString));
        }
        return RetrieveLabKitCount(this._connectionString);
        
    }

    public int RetrieveBloodCount(string connectionString)
    {
          try
        {
            //Set up DB Connection
            using SqlConnection connection = new(connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.[LabSystem]";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            //Execute the Query
            using var reader = cmd.ExecuteReader(); //flexing options here with the use of var.

            //Extract the Results
            while (reader.Read())
             {
                //for each iteration -> extract the results to a User object -> add to list.
                if ((string)reader["ItemName"] == "Blood")
                {
                    return Decimal.ToInt32((decimal)reader["CurrentBloodCount"]);
                }
            }

           throw new Exception("No Counts Found");
        }
         catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return 0;
        }

        // foreach(var item in userStorage.users)
        // {
        //     users.Add(item.Value);
        // }

        // return users;
    }

     public int RetrieveLabKitCount(string connectionString)
    {
          try
        {
            //Set up DB Connection
            using SqlConnection connection = new(connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.[LabSystem]";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            //Execute the Query
            using var reader = cmd.ExecuteReader(); //flexing options here with the use of var.

            //Extract the Results
            while (reader.Read())
             {
                //for each iteration -> extract the results to a User object -> add to list.
                if ((string)reader["ItemName"] == "LabKit")
                {
                    return Decimal.ToInt32((decimal)reader["CurrentLabKitCount"]);
                }
            }

           throw new Exception("No Counts Found");
        }
         catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return 0;
        }

        // foreach(var item in userStorage.users)
        // {
        //     users.Add(item.Value);
        // }

        // return users;
    }

    public void AddBlood(int bloodCount)
    {
        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();
        int countToUpdate = RetrieveBloodCount(_connectionString) + bloodCount;
        //Create the SQL String
        string sql = "UPDATE dbo.[LabSystem] SET CurrentBloodCount = @CurrentBloodCount where ItemName= @ItemName";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@CurrentBloodCount", countToUpdate);
        cmd.Parameters.AddWithValue("@ItemName", "Blood");

        //Execute the Query
        cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)
        //using SqlDataReader reader = cmd.ExecuteReader();
        
    }

    public void AddLabKits(int labKits)
    {
         //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();
         int countToUpdate = RetrieveLabKitCount(_connectionString) + labKits;
        //Create the SQL String
        string sql = "UPDATE dbo.[LabSystem] SET CurrentLabKitCount = @CurrentLabKitCount where ItemName= @ItemName";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@CurrentLabKitCount", countToUpdate);
        cmd.Parameters.AddWithValue("@ItemName", "LabKit");

        //Execute the Query
        cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)
        //using SqlDataReader reader = cmd.ExecuteReader();
    }

     public void UpdateBlood(int bloodCount, int bloodCountToSubtract)
    {
        int bloodCountToUpdate = bloodCount + bloodCountToSubtract;

        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "UPDATE dbo.[LabSystem] SET CurrentBloodCount = @CurrentBloodCount where ItemName= @ItemName";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@CurrentBloodCount", bloodCountToUpdate);
        cmd.Parameters.AddWithValue("@ItemName", "Blood");

        //Execute the Query
        cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)
        //using SqlDataReader reader = cmd.ExecuteReader();
        
    }
}
