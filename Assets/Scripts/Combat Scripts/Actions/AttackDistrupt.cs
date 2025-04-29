using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDistrupt : BallAction
{

    public override void Function(float Value)

    {
        if (Value == 3)
        {
            FindObjectOfType<Enemy>().Shield -= (1 + FindObjectOfType<Player>().POWER);
            FindObjectOfType<Player>().POWER = 0;
            FindObjectOfType<Enemy>().HP--;
        }

        if (Value == 4)
        {
            FindObjectOfType<Enemy>().Shield -= (2 + FindObjectOfType<Player>().POWER);
            FindObjectOfType<Player>().POWER = 0;
            FindObjectOfType<Enemy>().HP--;
        }

        if (Value == 5)
        {
            FindObjectOfType<Enemy>().Shield -= (3 + FindObjectOfType<Player>().POWER);
            FindObjectOfType<Player>().POWER = 0;
            FindObjectOfType<Enemy>().HP--;
        }


        float HP = FindObjectOfType<Player>().HP;
        float POWER = FindObjectOfType<Player>().POWER;
        Debug.Log("HP: " + HP);
        Debug.Log("POWER: " + POWER);
    }

}