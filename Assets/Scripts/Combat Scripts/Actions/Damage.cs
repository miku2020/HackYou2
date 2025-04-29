using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damage : BallAction
{
    

    public override void Function(float Value)
    {
        if (Value == 3)
        {
            FindObjectOfType<Enemy>().HP -= Mathf.Clamp(2 - FindObjectOfType<Enemy>().Shield , 0f, 100f) + FindObjectOfType<Player>().POWER;
            FindObjectOfType<Player>().POWER = 0;
        }

        if (Value == 4)
        {
            FindObjectOfType<Enemy>().HP -= Mathf.Clamp(3 - FindObjectOfType<Enemy>().Shield + FindObjectOfType<Player>().POWER, 0f, 100f);
            FindObjectOfType<Player>().POWER = 0;
        }

        if (Value == 5)
        {
            FindObjectOfType<Enemy>().HP -= Mathf.Clamp(2 - FindObjectOfType<Enemy>().Shield + FindObjectOfType<Player>().POWER, 0f, 100f);
            FindObjectOfType<Player>().POWER = 0;
        }


            float HP = FindObjectOfType<Enemy>().HP;
            Debug.Log("ENEMY HP: " + HP);
    }

}
