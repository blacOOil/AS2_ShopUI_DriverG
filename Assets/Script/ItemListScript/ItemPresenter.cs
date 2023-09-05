using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Inventory.ItemArray;
using Inventory.ItemData;
using TMPro;


namespace Inventory.ItemPresenter
{

    public class ItemPresenter : MonoBehaviour
    {
        public TextMeshProUGUI ItemTextUi;

        public static ItemPresenter Instance;
        public List<Item> Items = new List<Item>();
       // [SerializeField] public Text UItext;

        [SerializeField]
        public Transform ItemContent;
        [SerializeField]
        public GameObject ShopItemPrefab;
      
      
        public void Start()
        {
            ListItem();
        }
        private void Awake()
        {
            
        }


        public void ListItem()
        {

            foreach (var item in Items)
            {
            GameObject itemUi = Instantiate(ShopItemPrefab, ItemContent);

                itemUi.transform.Find("Image").GetComponent<Image>().sprite = item.Icon;
                ItemTextUi = itemUi.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
                ItemTextUi.text = item.ItemName;
              
                
          
            }

        }

    }
}
