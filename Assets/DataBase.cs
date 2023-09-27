using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// Help to work with the interface in Unity


public class DataBase : MonoBehaviour
{
    public List<Item> items = new List<Item>()// Allows to create a list of items that ve will have
}

[System.Serializable] //Allows to have access to any point of this script

public class Item
{
    public int id; //It will help you understand what kind of item it is(1,2,1...)
    public string name;//Item name
    public Sprite img;//Bild
}


