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

    public override string ToString()
    {
        // #ERROR you cannot leave this method empty because it returns a value.  if waiting to implement use throw new Not Implemented Exception
        throw new NotImplementedException();
    }
}