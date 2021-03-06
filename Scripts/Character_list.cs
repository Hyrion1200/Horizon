﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Photon.Pun;

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
        int o = 1;
        foreach (int selected in selection)
        {
            
            if (selected == 0)
            {
                if (o == 1)
                {
                    PhotonNetwork.Instantiate(Path.Combine("Prefab","warriorPrefab"), new Vector3(5.5f, 0.25f, 1), Quaternion.identity);
                    o++;
                }
                else if (o == 2)
                {
                    PhotonNetwork.Instantiate(Path.Combine("Prefab", "warriorPrefab"), new Vector3(6.5f, 0.75f, 1), Quaternion.identity);
                    o++;
                }
                else if (o == 3)
                {
                    PhotonNetwork.Instantiate(Path.Combine("Prefab", "warriorPrefab"), new Vector3(7.5f, 1.25f, 1), Quaternion.identity);
                    o++;
                }

            }
            else if (selected == 1)
            {
                if (o == 1)
                {
                    PhotonNetwork.Instantiate(Path.Combine("Prefab", "wizardPrefab"), new Vector3(5.5f, 0.25f, 1), Quaternion.identity);
                    o++;
                }
                else if (o == 2)
                {

                    PhotonNetwork.Instantiate(Path.Combine("Prefab", "wizardPrefab"), new Vector3(6.5f, 0.75f, 1), Quaternion.identity);
                    o++;
                }
                else if (o == 3)
                {
                    PhotonNetwork.Instantiate(Path.Combine("Prefab", "wizardPrefab"), new Vector3(7.5f, 1.25f, 1), Quaternion.identity);
                    o++;
                }
            }
        }
    }

    public List<int> selection = new List<int>();
    int i = 1;
    public void selectCharacter(int id)
    { 
        selection.Add(id);
        if (i == 3)
        {
            generateCharacter();
            loadScene();
        }
        i++;
    }

    public void loadScene()
    {
        SceneManager.LoadScene("Game");
    }
}
