using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.ItemList
{
    public class ItemList : MonoBehaviour
    {
        public Item[] ItemArray => ItemRizz.ToArray();
        [SerializeField] List<Item> ItemRizz = new List<Item>();
        public Item[] GetItemsByType(ItemType target)
        {
            var resutList = new List<Item>();
            foreach (var Item in ItemRizz)
            {
                if (Item.type == target)
                    resutList.Add(Item);
            }
            return resutList.ToArray();
        }
        public void Add(Item itemadd)
        {

        }
        public void Remove(Item itemremove)
        {

        }
        [SerializeField]
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
            Weapon, Heal
        }
    }
}