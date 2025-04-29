using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindMatches : MonoBehaviour
{
    private Board board;
    public List<GameObject> currentMatches = new List<GameObject>();
    public int HP;
    private GameObject Health;
    public int Red;
    public int Blue;
    public int Green;
    public int White;
    public int Purple;
    public int Yellow;
    public bool test;
    private Player player;

    // Use this for initialization
    void Start()
    {
        board = FindObjectOfType<Board>();
        player = FindObjectOfType<Player>();
        HP = 10;
        test = false;
    }

    public void FindAllMatches()
    {
        Red = 0;
        Blue = 0;
        Green = 0;
        White = 0;
        Purple = 0;
        Yellow = 0;
        //StartCoroutine(FindAllMatchesCo());
        FindAllMatchesCo();
        player.Gamelogic(Red, Blue, Green, Purple, White, Yellow);
        Red = 0;

    }
    

    private void FindAllMatchesCo()
    {
        //yield return new WaitForSeconds(.2f);
        for (int i = 0; i < board.width; i++)
        {
            for (int j = 0; j < board.height; j++)
            {
                GameObject currentDot = board.allDots[i, j];
                if (currentDot != null)
                {
                    //Debug.Log(currentDot.tag);
                    if (i > 0 && i < board.width - 1)
                    {
                        GameObject leftDot = board.allDots[i - 1, j];
                        GameObject rightDot = board.allDots[i + 1, j];
                        if (leftDot != null && rightDot != null)
                        {
                            if (leftDot.tag == currentDot.tag && rightDot.tag == currentDot.tag)
                            {
                                if (!currentMatches.Contains(leftDot))
                                {
                                    currentMatches.Add(leftDot);
                                   
                                    if(currentDot.tag == "Dot-Red")
                                    {
                                        Red++;                                       
                                    }
                                    if (currentDot.tag == "Dot-Blue")
                                    {
                                        Blue++;
                                    }
                                    if (currentDot.tag == "Dot-Green")
                                    {
                                        Green++;
                                    }
                                    if (currentDot.tag == "Dot-Purple")
                                    {
                                        Purple++;
                                    }
                                    if (currentDot.tag == "Dot-White")
                                    {
                                        White++;
                                    }
                                    if (currentDot.tag == "Dot-Yellow")
                                    {
                                        Yellow++;
                                    }
                                }
                                leftDot.GetComponent<Dot>().isMatched = true;
                                if (!currentMatches.Contains(rightDot))
                                {
                                    currentMatches.Add(rightDot);
                                   
                                    if (currentDot.tag == "Dot-Red")
                                    {
                                        Red++;
                                        
                                    }
                                    if (currentDot.tag == "Dot-Blue")
                                    {
                                        Blue++;
                                    }
                                    if (currentDot.tag == "Dot-Green")
                                    {
                                        Green++;
                                    }
                                    if (currentDot.tag == "Dot-Purple")
                                    {
                                        Purple++;
                                    }
                                    if (currentDot.tag == "Dot-White")
                                    {
                                        White++;
                                    }
                                    if (currentDot.tag == "Dot-Yellow")
                                    {
                                        Yellow++;
                                    }
                                }
                                rightDot.GetComponent<Dot>().isMatched = true;

                                currentDot.GetComponent<Dot>().isMatched = true;
                                if (!currentMatches.Contains(currentDot))
                                {
                                    currentMatches.Add(currentDot);
                                    
                                    if (currentDot.tag == "Dot-Red")
                                    {
                                        Red++;
                                        
                                    }
                                    if (currentDot.tag == "Dot-Blue")
                                    {
                                        Blue++;
                                    }
                                    if (currentDot.tag == "Dot-Green")
                                    {
                                        Green++;
                                    }
                                    if (currentDot.tag == "Dot-Purple")
                                    {
                                        Purple++;
                                    }
                                    if (currentDot.tag == "Dot-White")
                                    {
                                        White++;
                                    }
                                    if (currentDot.tag == "Dot-Yellow")
                                    {
                                        Yellow++;
                                    }
                                }
                                
                            }
                        }
                    }
                    if (j > 0 && j < board.height - 1)
                    {
                        GameObject upDot = board.allDots[i, j + 1];
                        GameObject downDot = board.allDots[i, j - 1];
                        if (upDot != null && downDot != null)
                            if (upDot.tag == currentDot.tag && downDot.tag == currentDot.tag)
                            {

                                if (!currentMatches.Contains(upDot))
                                {
                                    currentMatches.Add(upDot);
                                    
                                    if (currentDot.tag == "Dot-Red")
                                    {
                                        Red++;
                                        
                                       
                                    }
                                    if (currentDot.tag == "Dot-Blue")
                                    {
                                        Blue++;
                                    }
                                    if (currentDot.tag == "Dot-Green")
                                    {
                                        Green++;
                                    }
                                    if (currentDot.tag == "Dot-Purple")
                                    {
                                        Purple++;
                                    }
                                    if (currentDot.tag == "Dot-White")
                                    {
                                        White++;
                                    }
                                    if (currentDot.tag == "Dot-Yellow")
                                    {
                                        Yellow++;
                                    }
                                }
                                upDot.GetComponent<Dot>().isMatched = true;
                                if (!currentMatches.Contains(downDot))
                                {
                                    currentMatches.Add(downDot);
                                   
                                    if (currentDot.tag == "Dot-Red")
                                    {
                                        Red++;
                                        
                                    }
                                    if (currentDot.tag == "Dot-Blue")
                                    {
                                        Blue++;
                                    }
                                    if (currentDot.tag == "Dot-Green")
                                    {
                                        Green++;
                                    }
                                    if (currentDot.tag == "Dot-Purple")
                                    {
                                        Purple++;
                                    }
                                    if (currentDot.tag == "Dot-White")
                                    {
                                        White++;
                                    }
                                    if (currentDot.tag == "Dot-Yellow")
                                    {
                                        Yellow++;
                                    }
                                }
                                downDot.GetComponent<Dot>().isMatched = true;
                                if (!currentMatches.Contains(currentDot))
                                {
                                    currentMatches.Add(currentDot);
                                   
                                    if (currentDot.tag == "Dot-Red")
                                    {
                                        Red++;
                                       
                                    }
                                    if (currentDot.tag == "Dot-Blue")
                                    {
                                        Blue++;
                                    }
                                    if (currentDot.tag == "Dot-Green")
                                    {
                                        Green++;
                                    }
                                    if (currentDot.tag == "Dot-Purple")
                                    {
                                        Purple++;
                                    }
                                    if (currentDot.tag == "Dot-White")
                                    {
                                        White++;
                                    }
                                    if (currentDot.tag == "Dot-Yellow")
                                    {
                                        Yellow++;
                                    }

                                }
                                currentDot.GetComponent<Dot>().isMatched = true;

                            }

                    }
                    
                }
            }

        }
        test = true;
       

    }
}


