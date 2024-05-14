public class LabSystemStorage
{
    public Dictionary<int, LabSystem> labs;
    public int IdCounter = 1; 

    public LabSystemStorage()
    {
         //Create items in the lab
       LabSystem lab1 = new (IdCounter, "Blood", 50, 0, null);
       LabSystem lab2 = new (IdCounter, "LabKit", 0, 50, null);
        
    }
    
}