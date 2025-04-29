using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_health : MonoBehaviour
{

    public Sprite Health1;
    public Sprite Health2;
    public Sprite Health3;
    public Sprite Health4;
    public Sprite Health5;
    public Sprite Health6;
    public Sprite Health7;
    public Sprite Health8;
    public Sprite Health9;
    public Sprite Health10;
    public SpriteRenderer SpriteRenderer;





    // Health_bar rendering
    void Update()
    {
        if (FindObjectOfType<Enemy>().HP == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health1;
        }
        if (FindObjectOfType<Enemy>().HP == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health2;
        }
        if (FindObjectOfType<Enemy>().HP == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health3;
        }
        if (FindObjectOfType<Enemy>().HP == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health4;
        }
        if (FindObjectOfType<Enemy>().HP == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health5;
        }
        if (FindObjectOfType<Enemy>().HP == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health6;
        }
        if (FindObjectOfType<Enemy>().HP == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health7;
        }
        if (FindObjectOfType<Enemy>().HP == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health8;
        }
        if (FindObjectOfType<Enemy>().HP == 9)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health9;
        }
        if (FindObjectOfType<Enemy>().HP == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health10;
        }

        if (FindObjectOfType<Enemy>().HP > 10)
        {
            FindObjectOfType<Enemy>().HP = 10;
        }

        if (FindObjectOfType<Enemy>().HP <= 0)
        {
            SpriteRenderer.enabled = false;
        }
        else { SpriteRenderer.enabled = true; }


    }
}
