public class UserStorage
{
    public Dictionary<int, User> users;
    public int IdCounter =1; 

    public UserStorage()
    {
        //Create Scientist employees
        User user1 = new User (IdCounter++, 1, 123, "John", "Jones", "Scientist");
        User user2 = new User (IdCounter++, 1, 123, "Jackie", "Smith", "Scientist");

        //Create Lab Assistants
        User user3 = new User (IdCounter++, 2, 456, "Jimmy", "Butler", "Lab Assitant");
        // #ERROR you cannot declare another variable of the same name, user1, create user 4
        User user4 = new User (IdCounter++, 2, 456, "Natalie", "Curry", "Lab Assitant");

        users = new Dictionary<int, User>();
        users.Add(user1.UserId, user1);
        users.Add(user2.UserId, user2);
        users.Add(user3.UserId, user3);
        users.Add(user4.UserId, user4);

    }


}