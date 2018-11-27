using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Single<T> : MonoBehaviour where T : Single<T>
{

    private static T instance;
    public static T Instance
    {

        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectsOfType(typeof(T)) as T;

            }
            if (instance == null)
            {

                GameObject go = new GameObject();
                instance = go.AddComponent<T>();

            }

            DontDestroyOnLoad(instance.gameObject);//加载场景不会销毁该物体和该脚本
            return instance;

        }



    }
}
