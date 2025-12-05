using UnityEngine;
using UnityEngine.UI;

public class EnergyBehaviour : MonoBehaviour
{
    static public int unusedEnergyLevel = 4;
    static public int unlockedEnergySlots = 4;
    static public int o2EnergyLevel = 0;
    static public int sEnergyLevel = 0;
    static public int eEnergyLevel = 0;
    static public int w1EnergyLevel = 0;
    static public int w2EnergyLevel = 0;
    public Button o2Add;
    public Button o2Remove;
    public Button sAdd;
    public Button sRemove;
    public Button eAdd;
    public Button eRemove;
    public Button w1Add;
    public Button w1Remove;
    public Button w2Add;
    public Button w2Remove;
    public GameObject o2Slot;
    public GameObject sSlot1;
    public GameObject sSlot2;
    public GameObject eSlot1;
    public GameObject eSlot2;
    public GameObject w1Slot;
    public GameObject w2Slot1;
    public GameObject w2Slot2;
    public GameObject unusedSlot1;
    public GameObject unusedSlot2;
    public GameObject unusedSlot3;
    public GameObject unusedSlot4;
    public GameObject unusedSlot5;
    public GameObject unusedSlot6;
    public GameObject unusedSlot7;
    public GameObject unusedSlot8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unusedEnergyLevel > 0)
        {
            unusedSlot1.SetActive(true);
        }
        else
        {
            unusedSlot1.SetActive(false);
        }
        if (unusedEnergyLevel > 1)
        {
            unusedSlot2.SetActive(true);
        }
        else
        {
            unusedSlot2.SetActive(false);
        }
        if (unusedEnergyLevel > 2)
        {
            unusedSlot3.SetActive(true);
        }
        else
        {
            unusedSlot3.SetActive(false);
        }
        if (unusedEnergyLevel > 3)
        {
            unusedSlot4.SetActive(true);
        }
        else
        {
            unusedSlot4.SetActive(false);
        }
        if (unusedEnergyLevel > 4 && unlockedEnergySlots > 4)
        {
            unusedSlot5.SetActive(true);
        }
        else
        {
            unusedSlot5.SetActive(false);
        }
        if (unusedEnergyLevel > 5 && unlockedEnergySlots > 5)
        {
            unusedSlot6.SetActive(true);
        }
        else
        {
            unusedSlot6.SetActive(false);
        }
        if (unusedEnergyLevel > 6 && unlockedEnergySlots > 6)
        {
            unusedSlot7.SetActive(true);
        }
        else
        {
            unusedSlot7.SetActive(false);
        }
        if (unusedEnergyLevel > 7 && unlockedEnergySlots > 7)
        {
            unusedSlot8.SetActive(true);
        }
        else
        {
            unusedSlot8.SetActive(false);
        }
    }
    public void O2Add()
    {
        if (o2EnergyLevel == 0 && unusedEnergyLevel != 0)
        {
            unusedEnergyLevel--;
            o2EnergyLevel++;
            o2Slot.SetActive(true);
        }
    }
    public void O2Remove()
    {
        if (o2EnergyLevel == 1)
        {
            unusedEnergyLevel++;
            o2EnergyLevel--;
            o2Slot.SetActive(false);
        }
    }
    public void SAdd()
    {
        if (sEnergyLevel < 2 && unusedEnergyLevel != 0)
        {
            unusedEnergyLevel--;
            sEnergyLevel++;
            if (sEnergyLevel > 0) sSlot1.SetActive(true);
            if (sEnergyLevel > 1) sSlot2.SetActive(true); 
        }
    }
    public void SRemove()
    {
        if (sEnergyLevel > 0)
        {
            unusedEnergyLevel++;
            sEnergyLevel--;
            if (sEnergyLevel < 2) sSlot2.SetActive(false);
            if (sEnergyLevel < 1) sSlot1.SetActive(false);

        }
    }
    public void EAdd()
    {
        if (eEnergyLevel < 2 && unusedEnergyLevel != 0)
        {
            unusedEnergyLevel--;
            eEnergyLevel++;
            if (eEnergyLevel > 0) eSlot1.SetActive(true);
            if (eEnergyLevel > 1) eSlot2.SetActive(true);
        }
    }
    public void ERemove()
    {
        if (eEnergyLevel > 0)
        {
            unusedEnergyLevel++;
            eEnergyLevel--;
            if (eEnergyLevel < 2) eSlot2.SetActive(false);
            if (eEnergyLevel < 1) eSlot1.SetActive(false);

        }
    }
    public void W1Add()
    {
        if (w1EnergyLevel == 0 && unusedEnergyLevel != 0)
        {
            unusedEnergyLevel--;
            w1EnergyLevel++;
            w1Slot.SetActive(true);
        }
    }
    public void W1Remove()
    {
        if (w1EnergyLevel == 1)
        {
            unusedEnergyLevel++;
            w1EnergyLevel--;
            w1Slot.SetActive(false);
        }
    }
    public void W2Add()
    {
        if (w2EnergyLevel < 2 && unusedEnergyLevel != 0)
        {
            unusedEnergyLevel--;
            w2EnergyLevel++;
            if (w2EnergyLevel > 0) w2Slot1.SetActive(true);
            if (w2EnergyLevel > 1) w2Slot2.SetActive(true);
        }
    }
    public void W2Remove()
    {
        if (w2EnergyLevel > 0)
        {
            unusedEnergyLevel++;
            w2EnergyLevel--;
            if (w2EnergyLevel < 2) w2Slot2.SetActive(false);
            if (w2EnergyLevel < 1) w2Slot1.SetActive(false);

        }
    }
}
