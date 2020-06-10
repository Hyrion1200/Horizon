using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnage : MonoBehaviour
{
    public PersonnageSO data;
    public bool CanAttack;
    public int hp;
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

    public virtual void basicAttack(int id)
    {

    }

    public virtual void heal(){

    }
}
