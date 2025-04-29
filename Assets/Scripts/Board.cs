using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    wait, 
    move

}

public class Board : MonoBehaviour
{
    private FindMatches findmatches;
    public GameState currentState = GameState.move;
    public int width;
    public int height;
    private Background_tile[,] alltiles;
    public Object tilePrefab;
    public GameObject[] dots;
    public GameObject[,] allDots;
    public int offSet;

    // Use this for initialization
    void Start()
    {
        findmatches = FindObjectOfType<FindMatches>();
        alltiles = new Background_tile[width, height];
        allDots = new GameObject[width, height];
        SetUp();
    }

    private void SetUp()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPosition = new Vector2(i, j + offSet);
                GameObject Background_tile = Instantiate(tilePrefab, tempPosition, Quaternion.identity) as GameObject;
                Background_tile.transform.parent = this.transform;
                Background_tile.name = "( " + i + " , " + j + " )";
                int DotToUse = Random.Range(0, dots.Length);
                int maxIteration = 0;
                while (MatchesAT(i, j, dots[DotToUse]) && maxIteration < 100)
                {
                    DotToUse = Random.Range(0, dots.Length);
                    maxIteration++;
                }
                maxIteration = 0;
                GameObject dot = Instantiate(dots[DotToUse], tempPosition, Quaternion.identity);
                dot.GetComponent<Dot>().Row = j;
                dot.GetComponent<Dot>().Column = i;
                dot.transform.parent = this.transform;
                dot.name = "( " + i + " , " + j + " )";
                allDots[i, j] = dot;
            }
        }

    }

    private bool MatchesAT(int Column, int Row, GameObject Pieces)
    {
        if (Column > 1 && Row > 1)
        {
            if (allDots[Column - 1, Row].tag == Pieces.tag && allDots[Column - 2, Row])
            {

                return true;
            }
            if (allDots[Column, Row - 2].tag == Pieces.tag && allDots[Column, Row - 2])
            {

                return true;
            }
        }
        else if (Column <= 1 || Row <= 1)
        {
            if (Row > 1)
            {
                if (allDots[Column, Row - 1].tag == Pieces.tag && allDots[Column, Row - 2].tag == Pieces.tag)
                {

                    return true;
                }
            }
            if (Column > 1)
            {
                if (allDots[Column - 1, Row].tag == Pieces.tag && allDots[Column - 2, Row].tag == Pieces.tag)
                {

                    return true;
                }
            }
        }
        return false;
    }

    private void DestroyMatchesAT(int Column, int Row)
    {
        //Debug.Log(findmatches.tag); //Liikaa 
        if (allDots[Column, Row].GetComponent<Dot>().isMatched)
        {
            //Debug.Log(findmatches.tag); //liikaa + Untagged
            //Debug.Log(findmatches.tag); //liikaa + Untagged

            if (findmatches.tag == "Dot-Red")
            {
                Debug.Log("YES RED");
            }
            findmatches.currentMatches.Remove(allDots[Column, Row]);
            Destroy(allDots[Column, Row]);
            allDots[Column, Row] = null;


        }
    }



    public void DestroyMatches()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (allDots[i, j] != null)
                {
                    //Debug.Log(findmatches.tag);
                    DestroyMatchesAT(i, j);
                    
                }
            }
        }
        StartCoroutine(DecreaseRowCo());
    }

    private IEnumerator DecreaseRowCo()
    {
        int nullCount = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {

                //Debug.Log(nullCount);
                if (allDots[i, j] == null)
                {

                    nullCount++;
                }
                else if (nullCount > 0)
                {

                    allDots[i, j].GetComponent<Dot>().Row -= nullCount;
                    allDots[i, j] = null;

                }
                //Debug.Log(allDots[i, j]);
            }
            nullCount = 0;
        }
        yield return new WaitForSeconds(.4f);
        
        StartCoroutine(FillBoardCo());
    }
    private void RefillBoard()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (allDots[i, j] == null)
                {
                    Vector2 tempPosition = new Vector2(i, j + offSet);
                    int DotToUse = Random.Range(0, dots.Length);
                    GameObject piece = Instantiate(dots[DotToUse], tempPosition, Quaternion.identity);
                    allDots[i, j] = piece;
                    piece.GetComponent<Dot>().Row = j;
                    piece.GetComponent<Dot>().Column = i;
                }
            }
        }
    }
    private bool MatchesOnBoard()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (allDots[i, j] != null)

                {
                    if (allDots[i, j].GetComponent<Dot>().isMatched)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    private IEnumerator FillBoardCo()
    {
        RefillBoard();
        yield return new WaitForSeconds(.5f);

        while (MatchesOnBoard())
        {
            yield return new WaitForSeconds(.5f);
            
            DestroyMatches();
        }
        yield return new WaitForSeconds(.5f);
        currentState = GameState.move;
    }

}
