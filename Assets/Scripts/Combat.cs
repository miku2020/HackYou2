using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{

    public GameObject Health;
    public int HP;
    //private Damage Redball;



    // Use this for initialization
    void Start()
    {
        HP = 10;
    }

    public void Damage()
    {
        HP--;
        TEXT();
    }


    public void TEXT()
    {

        Health.GetComponent<Text>().text = HP.ToString() ;

    }

}