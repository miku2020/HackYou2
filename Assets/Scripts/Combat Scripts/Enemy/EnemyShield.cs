using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShield : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;

    // Use this for initialization
    void Start()
    {
        SpriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Enemy>().Shield < 1)
        {
            SpriteRenderer.enabled = false;
        }
    }
}
