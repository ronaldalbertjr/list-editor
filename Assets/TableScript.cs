using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class Item
{
    public string key = "New Key";
    public int value;
}

[ExecuteInEditMode]
public class TableScript : MonoBehaviour
{
    public List<Item> lista = new List<Item>();
    
}
