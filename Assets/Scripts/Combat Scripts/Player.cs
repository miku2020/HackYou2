
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[HideInInspector]


    public BallAction Redball;
    public BallAction Blueball;
    public BallAction Greenball;
    public BallAction Yellowball;
    public BallAction Purpleball;
    public BallAction Whiteball;

    public Animator animator;
    public AudioSource Audio;

    private Enemy enemyaction;

    public AudioClip HealAudio;
    public AudioClip AttackAudio;
    public AudioClip ShieldAudio;
    public AudioClip DistruptAudio;
    public AudioClip LeachAudio;
    public AudioClip POWERAudio;

    public float HP;
    public float POWER;
    public float Shield;
    public float ShieldTimer;
    public float DistruptTimer;


    // Use this for initialization
    void Start()
    {
        enemyaction = FindObjectOfType<Enemy>();
       


    }


    public void Gamelogic(int Red, int Blue, int Green, int Purple, int White, int Yellow)
    {

        if (Red > 0)
        {
            if (Red > 4)
            {
                Debug.Log("Red Val: " + Red);
                Redball.Function((float)Red);
                
            }
            else if (Red > 3)
            {
                Debug.Log("Red Val: " + Red);
                Redball.Function((float)Red);
                
            }
            else if (Red > 2)
            {
                Debug.Log("Red Val: " + Red);
                Redball.Function(Red);
                
            }

            GetComponent<Animator>().SetBool("Attack", true);
            Audio.clip = AttackAudio;
            Audio.Play();
            FindObjectOfType<Enemy>().Damaged();

        }


        if (Blue != 0)
        {
            if (Blue > 4)
            {
                Debug.Log("Blue Val: " + Blue);
                Blueball.Function((float)Blue);
                
            }
            else if (Blue > 3)
            {
                Debug.Log("Blue Val: " + Blue);
                Blueball.Function((float)Blue);
            }
            else if (Blue > 2)
            {
                Blueball.Function(Blue);
                Debug.Log("Blue Val: " + Blue);
            }
            GetComponent<Animator>().SetBool("Attack", true);
            Audio.clip = POWERAudio;
            Audio.Play();
        }


        if (Green > 0)
        {
            if (Green > 4)
            {
                Debug.Log("Green Val: " + Green);
                Greenball.Function((float)Green);
            }
            else if (Green > 3)
            {
                Debug.Log("Green Val: " + Green);
                Greenball.Function((float)Green);
            }
            else if (Green > 2)
            {
                Greenball.Function(Green);
                Debug.Log("Green Val: " + Green);
            }
            GetComponent<Animator>().SetBool("Attack", true);
            Audio.clip = DistruptAudio;
            Audio.Play();
            FindObjectOfType<Enemy>().Damaged();
        }


        if (Purple != 0)
        {

            if (Purple > 4)
            {
                Debug.Log("Purple Val: " + Purple);
                Purpleball.Function((float)Purple);
            }
            else if (Purple > 3)
            {
                Debug.Log("Purple Val: " + Purple);
                Purpleball.Function((float)Purple);
            }
            else if (Purple > 2)
            {
                Debug.Log("Purple Val: " + Purple);
                Purpleball.Function(Purple);
            }
            GetComponent<Animator>().SetBool("Attack", true);
            Audio.clip = LeachAudio;
            Audio.Play();
            FindObjectOfType<Enemy>().Damaged();

        }


        if (White > 0)
        {
            if (White > 4)
            {
                Debug.Log("White Val: " + White);
                Whiteball.Function((float)White);
            }
            else if (White > 3)
            {
                Debug.Log("White Val: " + White);
                Whiteball.Function((float)White);
            }
            else if (White > 2)
            {
                Whiteball.Function(White);
                Debug.Log("White Val: " + White);
            }
            GetComponent<Animator>().SetBool("Attack", true);
            
            Audio.clip = HealAudio;
            Audio.Play();

        }


        if (Yellow != 0)
        {
            if (Yellow > 4)
            {
                Debug.Log("Yellow Val: " + Yellow);
                Yellowball.Function((float)Yellow);
            }
            else if (Yellow > 3)
            {
                Debug.Log("Yellow Val: " + Yellow);
                Yellowball.Function((float)Yellow);
            }
            else if (Yellow > 2)
            {
                Yellowball.Function(Yellow);
                Debug.Log("Yellow Val: " + Yellow);
            }
            GetComponent<Animator>().SetBool("Attack", true);
            Audio.clip = ShieldAudio;
            Audio.Play();
        }

     


    }

    public void AnimationEnded()
    {
        GetComponent<Animator>().SetBool("Attack", false);
        GetComponent<Animator>().SetBool("hurt", false);
        ShieldTimer--;
        DistruptTimer--;
        if (ShieldTimer < 1)
        {
            Shield = 0;
            ShieldTimer = 0;
        }
        
    }

    public void GotHurt()
    {
        GetComponent<Animator>().SetBool("hurt", true);
        
    }




}
