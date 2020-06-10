using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

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
    
    public Transform warriorPrefab;
    public Transform wizardPrefab;

   

    public void generateCharacter()
    {
        foreach (int selected in selection)
        {
          if (selected == 0)
            {
                Instantiate(warriorPrefab, new Vector2(0, 0), Quaternion.identity);
            }

          else if (selected == 1)
            {
                Instantiate(wizardPrefab, new Vector2(0, 0), Quaternion.identity);
            }
        }
    }

    public List<int> selection = new List<int>();

    public void selectCharacter(int id)
    {
        int i = 0;
        selection.Add(id);
        string result = "List contents : ";
        foreach (int selected in selection)
        {
            result += selected + ", ";
            i++;
        }

        Debug.Log(result);
        if (i == 3)
        {
            generateCharacter();
        }
    }

    public void loadScene()
    {
        SceneManager.LoadScene("Game");
    }
}
