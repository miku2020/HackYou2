using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthbar_UI : MonoBehaviour
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
	void Update ()
    {
		if (FindObjectOfType<Player>().HP == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health1;
        }
        if (FindObjectOfType<Player>().HP == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health2;
        }
        if (FindObjectOfType<Player>().HP == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health3;
        }
        if (FindObjectOfType<Player>().HP == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health4;
        }
        if (FindObjectOfType<Player>().HP == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health5;
        }
        if (FindObjectOfType<Player>().HP == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health6;
        }
        if (FindObjectOfType<Player>().HP == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health7;
        }
        if (FindObjectOfType<Player>().HP == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health8;
        }
        if (FindObjectOfType<Player>().HP == 9)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health9;
        }
        if (FindObjectOfType<Player>().HP == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Health10;
        }

        if (FindObjectOfType<Player>().HP > 10)
        {
            FindObjectOfType<Player>().HP = 10;
        }

        if (FindObjectOfType<Player>().HP <= 0)
        {
            SpriteRenderer.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else { SpriteRenderer.enabled = true; }


    }
}
