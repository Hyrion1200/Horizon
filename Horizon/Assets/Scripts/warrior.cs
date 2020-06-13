using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class warrior : personnage
{
    public personnage ennemy;
    public personnage ally;
    public int id;

    private PhotonView PV;

    public void Start()
    {
        PV = gameObject.GetComponent<PhotonView>();
    }

    public override void basicAttack(int id)
    {
        PV.RPC("basicAttack_RPC", RpcTarget.AllViaServer, id);
    }

    [PunRPC]
    public void basicAttack_RPC(int id)
    {
        int attack = data.attack;
        personnage target = ennemy;

        Debug.Log(attack + " on : " + target.name);
        target.hp -= attack;
        target.CanAttack = true;
        this.CanAttack = false;
        UI_Button_Switch.instance.updateButton();
    }

    public override void heal()
    {
        int heal = 5;
        personnage target = ally;
        target.hp += heal;
        target.CanAttack = true;
        this.CanAttack = false;
        UI_Button_Switch.instance.updateButton();
    }
}
