﻿using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T _instance = null;

    public static T Instance {
        get {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));
                if (_instance == null)
                {

                    string goName = typeof(T).ToString();

                    GameObject go = GameObject.Find(goName);
                    if (go == null)
                    {
                        go = new GameObject();
                        go.name = goName;
                    }

                    _instance = go.AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    protected void SetParent(string parentGOName)
    {
        if (parentGOName != null)
        {
            GameObject parentGO = GameObject.Find(parentGOName);
            if (parentGO == null)
            {
                parentGO = new GameObject
                {
                    name = parentGOName
                };
            }
            transform.parent = parentGO.transform;
        }
    }
}
