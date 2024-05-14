class LabSystem
{
    public int Id{get; set; }
    public string ItemName {get; set;}
    public int CurrentCount{get; set; }
    public int User? Id{get; set;}

    //No Arg constructor
    public LabSystem()
    {

    }

    //Full Arg Constructor
    public LabSystem(int id, string itemname, int currentcount, int user?id)
    {
        Id=id;
        ItemName = itemname;
        CurrentCount = currentcount;
        user?Id = user?id; 
    }

    public override string ToString()
    {
        return 
    }
}