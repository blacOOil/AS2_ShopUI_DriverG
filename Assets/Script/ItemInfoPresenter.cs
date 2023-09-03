using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Inventory.ItemArray;
using Inventory.ItemData;
using TMPro;


namespace Inventory.ItemInfoPresenter
{

    public class ItemInfoPresenter : MonoBehaviour
    {
        public TextMeshProUGUI ItemTextName,ItemTextInfo;

        public static ItemInfoPresenter Instance;
        public List<Item> Items = new List<Item>();
       // [SerializeField] public Text UItext;

        [SerializeField]
        public Transform ItemContent;
        [SerializeField]
        public GameObject ShopItemPrefab;
      
      
        public void Start()
        {
            ListItemInfo();
        }
        private void Awake()
        {
        }


        public void ListItemInfo()
        {

            foreach (var item in Items)
            {
            GameObject itemUi = Instantiate(ShopItemPrefab, ItemContent);

                itemUi.transform.Find("InfoImage").GetComponent<Image>().sprite = item.Icon;
                ItemTextInfo = itemUi.transform.Find("InfoItem").GetComponent<TextMeshProUGUI>();
                ItemTextInfo.text = item.ItemInfo;

                ItemTextName = itemUi.transform.Find("InfoItemName").GetComponent<TextMeshProUGUI>();
                ItemTextName.text = item.ItemName;
              
                
          
            }

        }

    }
}
