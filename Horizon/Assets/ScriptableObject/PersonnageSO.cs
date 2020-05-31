using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="NewPersonnage", menuName ="Personnage")]
public class PersonnageSO : ScriptableObject
{
    public int attack;
    public new string name;
    public int health;

    public Sprite spriteBack;
    public Sprite spriteFace;
}
