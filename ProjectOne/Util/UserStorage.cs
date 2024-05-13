class UserStorage
{
    public Dictionary<int, User> users;
    public int IdCounter =1; 

    public UserStorage()
    {
        //Create Scientist employees
        User user1 = new User (IdCounter++, 1, 1, 123, "John", "Jones", "Scientist");
        User user2 = new User (IdCounter++, 1, 1, 123, "Jackie", "Smith", "Scientist");

        //Create Lab Assistants
        User user3 = new User (IdCounter++, 1, 2, 456, "Jimmy", "Butler", "Lab Assitant");
        User user1 = new User (IdCounter++, 1, 2, 456, "Natalie", "Curry", "Lab Assitant");

    }
}