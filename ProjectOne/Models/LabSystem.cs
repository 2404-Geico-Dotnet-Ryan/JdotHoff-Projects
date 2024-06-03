public class LabSystem
{
    public int Id{get; set; }
    public string ItemName {get; set;}
    public int CurrentBloodCount{get; set; }
    public int CurrentLabkitCount{get; set; }

    //No Arg constructor
    public LabSystem()
    {

    }

    //Full Arg Constructor
    public LabSystem(int id, string itemname, int currentbloodcount, int currentlabkitcount)
    {
        Id=id;
        ItemName = itemname;
        CurrentBloodCount = currentbloodcount;
        CurrentLabkitCount = currentlabkitcount; 
    }

    public override string ToString() //returns a string that represents the current object
    {
       string newString = "";
        newString += "{Id " + Id;
        newString += ", Item Name " + ItemName;
        newString += ", Current Blood Count " + CurrentBloodCount;
        newString += ", Current Lab Kit Count " + CurrentLabkitCount;
        newString += "}";
        return newString;
    }
}