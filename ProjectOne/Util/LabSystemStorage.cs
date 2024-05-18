
public class LabSystemStorage
{
    private SqlGateway sqlGateway = new SqlGateway();
    public Dictionary<int, LabSystem> labs;
    public int IdCounter = 1; 

    public LabSystemStorage()
    {

        // TODO - call InitializeLabSystems to populate dictionary when ready instead of doing the below
    
         //Create items in the lab
       LabSystem lab1 = new (IdCounter, "Blood", 50, 0);
       IdCounter++;
       LabSystem lab2 = new (IdCounter, "LabKit", 0, 50);
        labs = new Dictionary<int, LabSystem>();
        labs.Add(lab1.Id, lab1);
        labs.Add(lab2.Id, lab2);
    }

    private void InitializeLabSystems()
    {
        var labSystems = sqlGateway.RetrieveAllLabSystems();
        foreach (LabSystem labSystem in labSystems)
        {
            labs.Add(labSystem.Id, labSystem);
        }

    } 
}