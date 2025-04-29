using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_special_attack : BallAction

{

    public override void Function(float Value)
    {
        FindObjectOfType<Enemy>().HP++;
        FindObjectOfType<Player>().POWER --;
        Debug.Log("Enemy Attack");
        GetComponent<Animator>().SetBool("sitdown", false);
        
    }


    public void AnimationEnded()
    {
        GetComponent<Animator>().SetBool("sitdown", true);
    }


}
