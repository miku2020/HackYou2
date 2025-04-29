using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score_text : MonoBehaviour
{
    public Text myText;
    private Enemy enemyscore;
    int test = 0;

    private void Start()
    {
        enemyscore = FindObjectOfType<Enemy>();
    }

    void Update()
    {
        myText.text = enemyscore.Score.ToString();

        test++;
    }
}