
public class LabSytstemService
{
    LabSystemStorage labStorage = new LabSystemStorage();
     public int RetrieveCurrentBloodCount()
    {
        int count = 0;
        foreach(var item in labStorage.labs)
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
        foreach(var item in labStorage.labs)
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
        var targetLabSystem = labStorage.labs.Where(x => x.Value.ItemName == "Blood").First();
        targetLabSystem.Value.CurrentBloodCount += bloodCount;
    }

    public void RemoveBlood(int bloodCount)
    {
       var targetLabSystem = labStorage.labs.Where(x => x.Value.ItemName == "Blood").First();
       targetLabSystem.Value.CurrentBloodCount -= bloodCount;
    }

    public void AddLabKits(int labKitCount)
    {
        var targetLabSystem = labStorage.labs.Where(x => x.Value.ItemName == "LabKit").First();
        targetLabSystem.Value.CurrentBloodCount += labKitCount;
    }

    public void RemoveLabkits(int labKitCount)
    {
       var targetLabSystem = labStorage.labs.Where(x => x.Value.ItemName == "LabKit").First();
       targetLabSystem.Value.CurrentBloodCount -= labKitCount;
    }       
}