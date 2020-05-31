using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button_Switch : MonoBehaviour
{
    #region Singleton 
    //on crée une unique instance accessible de partout
    public static UI_Button_Switch instance;
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

    public personnage j1;
    public personnage j2;

    public Button buttonJ1;
    public Button buttonJ2;

    private void Start()
    {
        updateButton();
    }

    public void updateButton()
    {
        buttonJ1.interactable = (j1.GetComponent<warrior>().CanAttack);
        buttonJ2.interactable = (j2.GetComponent<warrior>().CanAttack);
    }
}
