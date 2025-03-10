using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Test
{
    [MenuItem("Test/test")]
    public static void Test1() 
    {
        if (Selection.gameObjects.Length > 0)
        {
            for (int i = 0; i < Selection.gameObjects.Length; i++)
            {


                float a = UnityEngine.Random.Range(-100f, 100);
                float b = UnityEngine.Random.Range(-100f, 100);
                Vector3 v = new Vector3(a,0,b);
                Selection.gameObjects[i].transform.position = v;
            }
        }
        
    }
    [MenuItem("Test/test2")]
    static void CopyObjTransform()
    {
        GameObject obj = UnityEditor.Selection.activeGameObject;
        if (obj != null)
        {
            string ret = obj.transform.localPosition.x + "," +
                         obj.transform.localPosition.y + "," +
                         obj.transform.localPosition.z + "," +
                         obj.transform.localEulerAngles.x + "," +
                         obj.transform.localEulerAngles.y + "," +
                         obj.transform.localEulerAngles.z + "," +
                         obj.transform.localScale.x + "," +
                         obj.transform.localScale.y + "," +
                         obj.transform.localScale.z;

            GUIUtility.systemCopyBuffer = ret;

            Debug.Log("Copy Transform Success : " + ret);
        }
    }
    [MenuItem("Test/test1")]
    static void PasteObjTransform()
    {
        GameObject obj = UnityEditor.Selection.activeGameObject;
        if (obj != null)
        {
            string ret = GUIUtility.systemCopyBuffer;
            string[] array = ret.Split(',');
            if (array.Length == 9)
            {
                Vector3 position = new Vector3(Convert.ToSingle(array[0]),
                                                Convert.ToSingle(array[1]),
                                                Convert.ToSingle(array[2]));

                Vector3 rotation = new Vector3(Convert.ToSingle(array[3]),
                                                Convert.ToSingle(array[4]),
                                                Convert.ToSingle(array[5]));

                Vector3 scale = new Vector3(Convert.ToSingle(array[6]),
                                                Convert.ToSingle(array[7]),
                                                Convert.ToSingle(array[8]));

                obj.transform.localPosition = position;

                Debug.Log("Paste Transform Success : " + position);
            }
            else
            {
                Debug.Log("Paste Transform Error");
            }
        }
    }
}
