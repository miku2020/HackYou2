using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHeal : BallAction
{

    public override void Function(float Value)

    {
        if (Value == 3)
        {
            FindObjectOfType<Player>().HP += 1 + FindObjectOfType<Player>().POWER;
            FindObjectOfType<Player>().POWER = 0;
        }

        if (Value == 4)
        {
            FindObjectOfType<Player>().HP += 2 + FindObjectOfType<Player>().POWER;
            FindObjectOfType<Player>().POWER = 0;
        }

        if (Value == 5)
        {
            FindObjectOfType<Player>().HP += 3 + FindObjectOfType<Player>().POWER;
            FindObjectOfType<Player>().POWER = 0;
        }


        float HP = FindObjectOfType<Player>().HP;
        float POWER = FindObjectOfType<Player>().POWER;
        Debug.Log("HP: " + HP);
        Debug.Log("POWER: " + POWER);
    }

}