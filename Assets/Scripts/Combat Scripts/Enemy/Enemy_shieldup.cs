using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shieldup : BallAction
{ 

    public override void Function(float Value)
    {
        FindObjectOfType<Enemy>().Shield = 1 + FindObjectOfType<Enemy>().POWER;
        FindObjectOfType<Enemy>().ShieldTimer += 2;
        Debug.Log("Enemy Attack");
        FindObjectOfType<EnemyShield>().SpriteRenderer.enabled = true;


    }


    public void AnimationEnded()
    {
        GetComponent<Animator>().SetBool("sitdown", false);
    }


}