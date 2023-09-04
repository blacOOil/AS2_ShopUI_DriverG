using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShopManagerscript : MonoBehaviour
{
   public int[,] shopItem = new int[5,5];
   public float Gem;
   public Text GemTXT;
   

    void Start()
    {
        GemTXT.text = "Gem:" + Gem.ToString();
        //ID
        shopItem[1,1] = 1;
        shopItem[1,2] = 2;
        shopItem[1,3] = 3;
        shopItem[1,4] = 4;
        //Price
        shopItem[2,1] = 10;
        shopItem[2,2] = 20;
        shopItem[2,3] = 30;
        shopItem[2,4] = 40;

        shopItem[3,1] = 0;
        shopItem[3,2] = 0;
        shopItem[3,3] = 0;
        shopItem[3,4] = 0;
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (Gem >= shopItem[2,ButtonRef.GetComponent<ButtonInfo>().ItemName])
        {
            Gem = shopItem[2,ButtonRef.GetComponent<ButtonInfo>().ItemName];
            shopItem[3,ButtonRef.GetComponent<ButtonInfo>().ItemName]++;
            GemTXT.text = "Gem" + Gem.ToString();
            ButtonRef.GetComponent<ButtonInfo>().Amount.text = shopItem[3, ButtonRef.GetComponent<ButtonInfo>().ItemName].ToString();
        }    

    }
}
