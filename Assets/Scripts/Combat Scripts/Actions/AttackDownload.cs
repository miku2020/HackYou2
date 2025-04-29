using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDownload : BallAction
{

public override void Function(float Value)

    {
        if (Value == 3)
        {
            FindObjectOfType<Enemy>().HP -= Mathf.Clamp((1 - FindObjectOfType<Enemy>().Shield + FindObjectOfType<Player>().POWER), 0f, 100f);
            FindObjectOfType<Player>().POWER += 1;
            FindObjectOfType<Player>().HP += 1;
        }

        if (Value == 4)
        {
            FindObjectOfType<Enemy>().HP -= Mathf.Clamp((2 - FindObjectOfType<Enemy>().Shield + FindObjectOfType<Player>().POWER), 0f, 100f);
            FindObjectOfType<Player>().POWER += 1;
            FindObjectOfType<Player>().HP += 1;
        }

        if (Value == 5)
        {
            FindObjectOfType<Enemy>().HP -= Mathf.Clamp((2 - FindObjectOfType<Enemy>().Shield + FindObjectOfType<Player>().POWER), 0f, 100f);
            FindObjectOfType<Player>().POWER += 2;
            FindObjectOfType<Player>().HP += 2;
        }


        float HP = FindObjectOfType<Player>().HP;
        float POWER = FindObjectOfType<Player>().POWER;
        Debug.Log("HP: " + HP);
        Debug.Log("POWER: " + POWER);
    }

}