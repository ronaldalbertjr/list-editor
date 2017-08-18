using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(TableScript))]
public class TableScriptEditor : Editor
{
    int indexToRemove;
    public override void OnInspectorGUI()
    {
        indexToRemove = -1;
        TableScript table = target as TableScript;
        Undo.RecordObject(table, "Table Changed");
        EditorGUI.BeginChangeCheck();
        foreach (Item i in table.lista)
        {
            EditorGUILayout.BeginHorizontal();
            i.key = EditorGUILayout.TextField(i.key);
            i.value = EditorGUILayout.IntField(i.value);
            if(GUILayout.Button("Remove"))
                indexToRemove = table.lista.IndexOf(i);
            EditorGUILayout.EndHorizontal();
        }
        if(indexToRemove >= 0)
            table.lista.RemoveAt(indexToRemove);
        if (GUILayout.Button("Add Item", GUILayout.Height(20)))
            table.lista.Add(new Item());
        
    }
}
