using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormAction : MonoBehaviour {

    public BallAction Action1;
    public BallAction Action2;
    public Animator Animator;
    private float Value = 1;
    

    public void EnemyFunction()
    {
        int RNG = Random.Range(0, 2);
        switch (RNG)
        {
            case 0:
                Action1.Function(Value);
                break;
            case 1:
                Action2.Function(Value);
                break;
        } 
    }


    

}
