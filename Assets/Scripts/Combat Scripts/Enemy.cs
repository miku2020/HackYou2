using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject Enemy1;
    private Animator Animation;
    public GameObject Enemy2;
    public GameObject Current;

    private int RNG;

    public float Score;
    public float HP;
    public float POWER;
    public float Shield;
    public float ShieldTimer;
    public float DistruptTimer;
    private bool spawning = false;
    private void Start()
    {

        Debug.Log(Current);
        if (Current == null)
        {

            StartCoroutine("Spawn");
            POWER = -1;

        }
        DontDestroyOnLoad(this.gameObject);
        
    }

    public void Action()
    {
        if (HP > 0)
        {

            if (Current.name == "Worm(Clone)")
            {
                Current.GetComponent<WormAction>().EnemyFunction();
            }
            if (Current.name == "Umbrella_man(Clone)")
            {
                Current.GetComponent<UmbemanAction>().EnemyFunction();
            }
            ShieldTimer--;
            DistruptTimer--;
            if (ShieldTimer < 1)
            {
                Shield = 0;
                ShieldTimer = 0;
            }



        }
        else
        {
            if (Current.name == "Worm(Clone)")
            {
                Current.GetComponent<WormAction>().GetComponent<Animator>().SetBool("Dead", true);
            }
            if (Current.name == "Umbrella_man(Clone)")
            {
                Current.GetComponent<UmbemanAction>().GetComponent<Animator>().SetBool("Dead", true);
            }



        }
    }


    public IEnumerator Spawn()
    {

        yield return new WaitForSeconds(2f);
        RNG = Random.Range(0, 2);
        if (RNG == 1)
        {
            Current = GameObject.Instantiate(Enemy1);
            HP = 9;

        }
        else
        {
            Current = GameObject.Instantiate(Enemy2);
            HP = 6;
        }
        POWER++;
        Score += 100f * 1.33f;
        Debug.Log("Score: " + Score);
        spawning = false;
        //Mathf.FloorToInt();
    }

    public void Damaged()
    {


        if (Current.name == "Worm(Clone)")
        {
            Current.GetComponent<Animation>().GetComponent<Animator>().SetBool("damaged", true);
        }
        if (Current.name == "Umbrella_man(Clone)")
        {
            Current.GetComponent<UmbemanAction>().GetComponent<Animator>().SetBool("damaged", true);
        }
       
        Debug.Log("AUTSH!");
    }

    public void DEAD()
    {
        Debug.Log("DEAD");
        GameObject.Destroy(Current);
        Current = null;
        if (!spawning)
        {
            StartCoroutine("Spawn");
        }
        spawning = true;
    }

}
