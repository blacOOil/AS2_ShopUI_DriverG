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
        //public List<Item> Items = new List<Item>();
        // [SerializeField] public Text UItext;

        [SerializeField]
        public Transform ItemContent;
        [SerializeField]
        public GameObject ItemPrefab;
      
      
        public void Start()
        {
            //ListItemInfo();
            List<Item> items = FindObjectOfType<Inventory.ItemPresenter.ItemPresenter>().Items;
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

                itemUi.transform.Find("InfoImage").GetComponent<Image>().sprite = item.Icon;
                ItemTextName = itemUi.transform.Find("InfoItemName").GetComponent<TextMeshProUGUI>();
                ItemTextName.text = item.ItemName;

                ItemTextInfo = itemUi.transform.Find("InfoItem").GetComponent<TextMeshProUGUI>();
                ItemTextInfo.text = item.ItemInfo;
              
          
            }

        }

    }
}
