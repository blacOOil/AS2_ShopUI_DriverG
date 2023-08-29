using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Inventory.ItemArray;

namespace Inventory.ItemPresenter
{
   
    public class ItemPresenter : MonoBehaviour
    {
        public static ItemPresenter Instance;
        public List<Item> Items = new List<Item>();
        [SerializeField]

        public Transform ItemContent;
        public GameObject ShopItem;

        public void Start()
        {

        }
        public void Update()
        {
            
        }
        private void Awake()
        {
            Instance = this;
        }
       public void Add(Item item)
        {
            Items.Add(item);
        }
        public void Remove(Item item)
        {
            Items.Remove(item);
        }
        public void ListItem()
        {
           
            foreach(var item in Items)
            {
                GameObject obj = Instantiate(ShopItem,ItemContent);
                var ItemNameShow = obj.transform.Find("ItemName").GetComponent<Text>();
                var ItemIconShow = obj.transform.Find("Icon").GetComponent<Image>();
                ItemNameShow.text = item.ItemName;
                ItemIconShow.sprite = item.Icon;
            }
        }

    }
    
}
