using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnage : MonoBehaviour
{
    public PersonnageSO data;
    public int hp;
    public bool CanAttack;

    public HealthBar healthBar;

    private void Start()
    {
        hp = data.health;
        healthBar.SetMaxHealth(hp);
    }

    private void Update()
    {
        healthBar.SetHealth(hp);
    }

    public virtual void basicAttack()
    {

    }

    public virtual void heal(){

    }
}
