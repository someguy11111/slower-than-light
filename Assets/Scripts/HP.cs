using UnityEngine;
using TMPro;

public class HP : MonoBehaviour
{
    static public int playerHpCurrent = 10;
    public int playerHpMax;
    public TextMeshProUGUI pHpBarText;
    private string playerHpBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHpCurrent = playerHpMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHpCurrent <= 0)
        {
            pHpBarText.text = "";
            return;
        }
        playerHpBar = null;
        for (int i = 0; i < playerHpCurrent; i++)
        {
            playerHpBar += "I";
        }
        pHpBarText.text = playerHpBar;
        
    }
}
