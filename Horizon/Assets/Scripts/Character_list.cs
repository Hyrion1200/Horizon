using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_list : MonoBehaviour
{
    #region Singleton 
    //on crée une unique instance accessible de partout
    public static Character_list instance;
    //appelé avant le start
    protected void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("erreur, il y a deja une instance NetworkItemsController");
            return;
        }
        instance = this;
    }
    #endregion

    public int[] characters;
}
