class User
{
    
    public int UserId{set; get; } //will start at 1 
    public int UserType{get; set; } //Used to determine menu display 1=Scientist 2=LabAssistant
    public int UserLogin{get; set; }
    public string FirstName{ get; set; }
    public string LastName {get; set; }
    public string UserTitle {get; set; }

    //*NO Arguments Constructor
    public User ()
    {

    }

    //Full Arugument Constructor
    public User(int userId, int userType, int userLogin, string firstName, string lastName, string usertitle)
    {
    UserId = userId;    
    UserType=userType;
    UserLogin=userLogin;
    FirstName=firstName;
    LastName=lastName;
    UserTitle=usertitle;
    }
    
//convert User to string
public override string ToString()
{
   string newString = "";
        newString += "{UserId " + UserId;
        newString += ", User Type " + UserType;
        newString += ", First Name " + FirstName;
        newString += ", Last Name " + LastName;
        newString += ", User Title " + UserTitle;
        newString += "}";
        return newString;
}

}