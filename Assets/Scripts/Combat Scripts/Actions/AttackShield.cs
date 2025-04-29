using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackShield : BallAction
{

    public override void Function(float Value)

    {
        if (Value == 3)
        {
            if (FindObjectOfType<Player>().Shield < 2)
            {
                FindObjectOfType<Player>().Shield = 1 + FindObjectOfType<Player>().POWER;
            }
            FindObjectOfType<Player>().ShieldTimer += 3;
            FindObjectOfType<Player>().POWER = 0;
            FindObjectOfType<ShieldonOff>().SpriteRenderer.enabled = true;
        }

        if (Value == 4)
        {
            if (FindObjectOfType<Player>().Shield < 2)
            {
                FindObjectOfType<Player>().Shield = 1 + FindObjectOfType<Player>().POWER;
            }
            FindObjectOfType<Player>().ShieldTimer += 4;
            FindObjectOfType<Player>().POWER = 0;
            FindObjectOfType<ShieldonOff>().SpriteRenderer.enabled = true;
        }

        if (Value == 5)
        {
            if (FindObjectOfType<Player>().Shield < 2)
            {
                FindObjectOfType<Player>().Shield = 2 + FindObjectOfType<Player>().POWER;
            }
            FindObjectOfType<Player>().ShieldTimer += 6;
            FindObjectOfType<Player>().POWER = 0;
            FindObjectOfType<ShieldonOff>().SpriteRenderer.enabled = true;
        }


        float HP = FindObjectOfType<Player>().HP;
        float POWER = FindObjectOfType<Player>().POWER;
        Debug.Log("HP: " + HP);
        Debug.Log("POWER: " + POWER);
    }

}