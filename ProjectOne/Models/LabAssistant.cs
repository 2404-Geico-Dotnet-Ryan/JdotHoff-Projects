
 using System;
 
 public class  LabAssistant
 {
    public int Id{ get; private set; }
    public string Title { get; private set;}

    public LabAssistant()
    {
        this.Id = 123;
        this.Title = "LabAssistant";
    }


    public LabAssistant(int Id, string Title)
    {
        this.Id = Id;
        this.Title = Title;
        
    }


 }