using UnityEngine;
using TMPro;
using System.Collections;
public class O2Behaviour : MonoBehaviour
{
    public float o2Speed = 0.5f;
    public TextMeshProUGUI o2Display;
    public int o2Amount = 100;
    public float o2DamageSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(O2LossAndRegen());
    }

    // Update is called once per frame
    void Update()
    {
        if (HP.playerHpCurrent <= 0)
        {
            return;
        }
        o2Display.text = "O2: " + o2Amount + "%";
        if (o2Amount < 20)
        {
            o2Display.color = Color.red;
        }
        else
        {
            o2Display.color = Color.white;
        }
    }
    IEnumerator O2LossAndRegen()
    {
        while (true)
        {
            if (EnergyBehaviour.o2EnergyLevel == 0 && HP.playerHpCurrent > 0)
            {
                if (o2Amount <= 0)
                {
                    HP.playerHpCurrent--;
                    yield return new WaitForSeconds(o2DamageSpeed);
                }
                else
                {
                yield return new WaitForSeconds(o2Speed);
                o2Amount--;
                }
            }
            else if (EnergyBehaviour.o2EnergyLevel == 1 && HP.playerHpCurrent > 0)
            {
                yield return new WaitForSeconds(o2Speed);
                o2Amount++;
            }
            else
            {
                yield break;
            }
        }
    }
}
