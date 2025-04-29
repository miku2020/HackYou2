using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPOWER : BallAction
{

    public override void Function(float Value)

    {
        if (Value == 3)
        {
            
            FindObjectOfType<Player>().POWER += 3;
        }

        if (Value == 4)
        {
            
            FindObjectOfType<Player>().POWER += 4;
        }

        if (Value == 5)
        {
            
            FindObjectOfType<Player>().POWER += 5;
        }


        float HP = FindObjectOfType<Player>().HP;
        float POWER = FindObjectOfType<Player>().POWER;
        Debug.Log("HP: " + HP);
        Debug.Log("POWER: " + POWER);
    }

}