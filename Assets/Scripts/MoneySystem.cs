using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MoneySystem : MonoBehaviour
{

    public TextMeshProUGUI moneyDisplay;

    public static int earnedMoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyDisplay.text = earnedMoney.ToString(); 
    }
}
