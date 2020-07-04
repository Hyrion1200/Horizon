using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="NewPersonnage", menuName ="Personnage")]
public class PersonnageSO : ScriptableObject
{
    public int attack;
    public new string name;
    public int health;
    public enum id
    {
        warrior,
        wizard
    };

    public Sprite spriteBack;
    public Sprite spriteFace;
    public Sprite spriteIcon;
}
