using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnage : MonoBehaviour
{
    public PersonnageSO data;
    public int hp;
    public bool CanAttack;

    private void Start()
    {
        hp = data.health;
    }

    public virtual void basicAttack()
    {

    }
}
