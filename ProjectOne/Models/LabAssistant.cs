
 using System;
 
 public class  LabAssistant
 {
    //properties
    public int Id{ get; private set; }
    public string Title { get; private set;}

    //No Arg Constructor
    public LabAssistant()
    {
        this.Id = 123;
        this.Title = "LabAssistant";
    }

    //Full Arg Constructor
    public LabAssistant(int Id, string Title)
    {
        this.Id = Id;
        this.Title = Title;
        
    }


 }