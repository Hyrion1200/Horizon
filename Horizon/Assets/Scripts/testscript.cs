using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class testscript : MonoBehaviour
{
    
     public void loadPlayer()
    {
        Debug.Log("Creating Player");
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "warriorPrefab"), Vector3.zero, Quaternion.identity);
    }

}
