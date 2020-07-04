using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Character");
        DontDestroyOnLoad(this.gameObject);
    }
}
