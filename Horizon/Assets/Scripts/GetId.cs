using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetId : MonoBehaviour
{
    public PersonnageSO.id id;

    public void OnClick()
    {
        Character_list.instance.selectCharacter((int)id);
    }
    
}
