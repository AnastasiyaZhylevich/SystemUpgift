using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;//Allows to manage items

public class Inventory : MonoBehaviour
{
    public DataBase data;
    public List<ItemInventory> items = new< ItemInventory > ();

    public GameObject gameObjShow;

    public GameObject InventoryMainObject;
    public int maxCount;//Maximum number of elements
    public void AddItem(int id, Item item, int count)//When we add an element,we need to read it id,name och quantity
    {
        items[id].id = items.id;
        items[id].count = count;
        items[id].itemGameObject.GetComponent<Image>().sprite = data.items[invItem.id].image;//
        if (invItem > 1 && invItem.id != 0)
        {
            items[id].itemGameObj.GetComponentInChildren<Text>().text = count.ToString();//Will translate into quantity and make a tex(it will allow uss to addup what we have)
        }
        else()
        {
            items[id].itemGameObj.GetComponentInChildren<Text>().text = "";//If 0 or 1 element-will not give out information
        }
    }
    public void AddInventoryItem(int id, ItemInventory invItem)
    {
        items[id].id = invItem.id;
        items[id].count = invItem.count;
        items[id].itemGameObject.GetComponent<Image>().sprite = item.image;
        if (invItem.count > 1 && item.id != 0)
        {
            items[id].itemGameObj.GetComponentInChildren<Text>().text = count.ToString();/
        }
        else ()
        {
            items[id].itemGameObj.GetComponentInChildren<Text>().text = "";
        }
    }
    public void AddGraphics()//Responsible for the image in the cell
    {
       for(int i = 0; i<maxCount; i++)
       {

            GameObject newItem = Instantiate(gameobjShow, InventoryMainObject.transform) as GameObject;// Manipulating the movement

            newItem.name = i.ToString();//Turns any content into text

            ItemInventory ii = new ItemInventory();
            ii.itemGameObject = newItem;

            RectTransform rt = newItem.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0, 0, 0);//Reset the local position item
            rt.localScale = new Vector3(1, 1, 1);//So that all the cells are the same
            newItem.GetComponentInChildren<ReactTransform>().localScale = new Vector3(1, 1, 1);//So that the scale does not change(f.e when we hold the cursor)

            Button tempButton = newItem.GetComponent<Button>();//Each item of inventory is a button

            items.Add(ii);// Adds element to ItomInventory
                
       }
    }
}
[System.Serializable]
public class ItemInventory
{
    public int id; //For id
    public GameObject itemGameObject;

    public int count;//Shows how many elements are in each stack

}