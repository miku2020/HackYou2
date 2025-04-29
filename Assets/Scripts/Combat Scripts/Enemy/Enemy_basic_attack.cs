using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_basic_attack : BallAction
{

    public override void Function(float Value)
    {
        FindObjectOfType<Player>().HP -= Mathf.Clamp(1 - FindObjectOfType<Player>().Shield, 0f, 100f) + FindObjectOfType<Enemy>().POWER;
        //FindObjectOfType<Player>().POWER = 0;
        Debug.Log("Enemy Attack");
        GetComponent<Animator>().SetBool("sitdown", true);
        FindObjectOfType<Player>().GotHurt();
    }


    public void AnimationEnded()
    {
        GetComponent<Animator>().SetBool("sitdown", false);
    }


}
