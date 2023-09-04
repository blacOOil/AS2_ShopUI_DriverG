using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Inventory.ItemArray
{
    public class ItemArray : MonoBehaviour
    { 
        public List<Item> Items = new List<Item>();
        [SerializeField]
 
        void start()
         {
          
         }
      
    }
  
    [System.Serializable]
    public class Item
    {

        public Sprite Icon;
        public string ItemName;
        public string ItemInfo;
        public float Amount;
        public ItemType type;
     
    }
    public enum ItemType
    {
        Weapon,Heal,resource,Gem,CharacterStar
    }


}
