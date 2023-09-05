using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Inventory.ItemArray;
using Inventory.ItemData;
using TMPro;


namespace Inventory.ItemPresenter
{

    public class ItemInfoPresenter : MonoBehaviour
    {
        public TextMeshProUGUI ItemTextName,ItemTextInfo;

        //public static ItemInfoPresenter Instance;
        //public List<Item> Items = new List<Item>();
        // [SerializeField] public Text UItext;

        [SerializeField]
        public Transform ItemContent;
        [SerializeField]
        public GameObject ItemPrefab;
      
      
        public void Start()
        {
            //ListItemInfo();
            List<Item> items = FindObjectOfType<ItemPresenter>().Items;
            Debug.Log("Number of items in the list: " + items.Count);
            ListItemInfo(items);
        }
        private void Awake()
        {
        }

        public void ListItemInfo(List<Item> items)
        {

            foreach (var item in items)
            {
                GameObject itemUi = Instantiate(ItemPrefab, ItemContent);
                itemUi.SetActive(true);

                Debug.Log("InfoImage: " + itemUi.transform.Find("InfoImage"));
                Debug.Log("InfoItemName: " + itemUi.transform.Find("InfoItemName"));
                Debug.Log("InfoItem: " + itemUi.transform.Find("InfoItem"));

                itemUi.transform.Find("InfoImage").GetComponent<Image>().sprite = item.Icon;
                ItemTextName = itemUi.transform.Find("InfoItemName").GetComponent<TextMeshProUGUI>();
                ItemTextName.text = item.ItemName;

                ItemTextInfo = itemUi.transform.Find("InfoItem").GetComponent<TextMeshProUGUI>();
                ItemTextInfo.text = item.ItemInfo;
              
          
            }

        }

    }
}
