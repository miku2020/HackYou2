using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldonOff : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;

	// Use this for initialization
	void Start ()
    {
        SpriteRenderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (FindObjectOfType<Player>().Shield < 1)
        {
            SpriteRenderer.enabled = false;
        }
	}
}
