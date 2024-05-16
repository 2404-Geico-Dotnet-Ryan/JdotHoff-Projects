
public class LabSystemStorage
{
    public Dictionary<int, LabSystem> labs;
    public int IdCounter = 1; 

    public LabSystemStorage()
    {
         //Create items in the lab
       LabSystem lab1 = new (IdCounter, "Blood", 50, 0);
       LabSystem lab2 = new (IdCounter++, "LabKit", 0, 50);
        labs = new Dictionary<int, LabSystem>();
        labs.Add(lab1.Id, lab1);
        labs.Add(lab2.Id, lab2);
    }

    public int RetrieveCurrentBloodCount()
    {
        int count = 0;
        foreach(var item in labs)
        {
           if(item.Value.ItemName == "Blood")
           {
            count += item.Value.CurrentBloodCount;
           }
        }
        return count;
    }

    public int RetrieveCurrentLabKitCount()
    {
        int count = 0;
        foreach(var item in labs)
        {
           if(item.Value.ItemName == "LabKit")
           {
            count += item.Value.CurrentLabkitCount;
           }
        }
        return count;
    }

    public void AddBlood(int bloodCount)
    {
        var targetLabSystem = labs.Where(x => x.Value.ItemName == "Blood").First();
        targetLabSystem.Value.CurrentBloodCount += bloodCount;
    }

    public void RemoveBlood(int bloodCount)
    {
       var targetLabSystem = labs.Where(x => x.Value.ItemName == "Blood").First();
       targetLabSystem.Value.CurrentBloodCount -= bloodCount;
    }

    public void AddLabKits(int labKitCount)
    {
        var targetLabSystem = labs.Where(x => x.Value.ItemName == "LabKit").First();
        targetLabSystem.Value.CurrentBloodCount += labKitCount;
    }

    public void RemoveLabkits(int labKitCount)
    {
       var targetLabSystem = labs.Where(x => x.Value.ItemName == "LabKit").First();
       targetLabSystem.Value.CurrentBloodCount -= labKitCount;
    }       
}