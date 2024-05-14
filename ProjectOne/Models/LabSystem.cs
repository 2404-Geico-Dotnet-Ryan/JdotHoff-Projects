public class LabSystem
{
    public int Id{get; set; }
    public string ItemName {get; set;}
    public int CurrentBloodCount{get; set; }
    public int CurrentLabkitCount{get; set; }
    public int UserId{get;set;}

    //No Arg constructor
    public LabSystem()
    {

    }

    //Full Arg Constructor
    public LabSystem(int id, string itemname, int currentbloodcount, int currentlabkitcount,int userid)
    {
        Id=id;
        ItemName = itemname;
        CurrentBloodCount = currentbloodcount;
        CurrentLabkitCount = currentlabkitcount; 
        userId = userid; 
    }

    public override string ToString()
    {
        
    }
}