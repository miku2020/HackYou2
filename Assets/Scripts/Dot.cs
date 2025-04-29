using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    #region Variables

    [Header("Muuttujia")]
    private Vector2 FirstTouchPosition;
    private Vector2 FinalTouchposition;
    public float SwipeAngle = 0;
    public int Column;
    public int Row;
    public int targetX;
    public int targetY;
    private GameObject OtherDot;
    private Board board;
    private Vector2 TempPosition;
    public bool isMatched = false;
    public int preColumn;
    public int preRow;
    public float SwipeResist = .9f;
    private FindMatches findmatches;
    private Enemy enemyaction;

    #endregion

    // Use this for initialization
    void Start()
    {
        board = FindObjectOfType<Board>();
        findmatches = FindObjectOfType<FindMatches>();
        enemyaction = FindObjectOfType<Enemy>();

        /*targetX = (int)transform.position.x;
        targetY = (int)transform.position.y;
        Row = targetY;
        Column = targetX;
        preColumn = Column;
        preRow = Row;*/

    }

    // Update is called once per frame
    void Update()
    {
        //Findmatches();
        targetX = Column;
        targetY = Row;

        if (Mathf.Abs(targetX - transform.position.x) > .1)
        { // move towards the Target
            TempPosition = new Vector2(targetX, transform.position.y);
            transform.position = Vector2.Lerp(transform.position, TempPosition, .5f);
            if (board.allDots[Column, Row] != this.gameObject)
            {
                board.allDots[Column, Row] = this.gameObject;
            }
            //findmatches.FindAllMatches();
        }
        else // Directly set the Position
        {
            TempPosition = new Vector2(targetX, transform.position.y);
            transform.position = TempPosition;
        }
        if (Mathf.Abs(targetY - transform.position.y) > .1)
        { // move towards the Target
            TempPosition = new Vector2(transform.position.x, targetY);
            transform.position = Vector2.Lerp(transform.position, TempPosition, .5f);
            if (board.allDots[Column, Row] != this.gameObject)
            {
                board.allDots[Column, Row] = this.gameObject;
            }
            //findmatches.FindAllMatches();
        }
        else // Directly set the Position
        {
            TempPosition = new Vector2(transform.position.x, targetY);
            transform.position = TempPosition;
        }
        if (isMatched) // MATCHES
        {
            //Debug.Log(OtherDot.tag);
            SpriteRenderer mySprite = GetComponent<SpriteRenderer>();
            mySprite.color = new Color(0f, 0f, 0f, .2f);
        }
        findmatches.FindAllMatches();
    }

    public IEnumerator CheckMoveCo()
    {

        yield return new WaitForSeconds(.5f);
        if (OtherDot != null)
        {
            //=== MISS MATCH RETURN ===\\\
            /* if (!isMatched && !OtherDot.GetComponent<Dot>().isMatched)
             {
                 OtherDot.GetComponent<Dot>().Row = Row;
                 OtherDot.GetComponent<Dot>().Column = Column;
                 Row = preRow;
                 Column = preColumn;
                 yield return new WaitForSeconds(.5f);
                 board.currentState = GameState.move;
             }
             else // Destroy
             {*/
            
            board.DestroyMatches();
                

           // }
           // OtherDot = null;

        }
    }

    private void OnMouseDown()
    {

        if (board.currentState == GameState.move)
        {

            FirstTouchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(FirstTouchPosition);
        }

    }

    private void OnMouseUp()
    {
        if (board.currentState == GameState.move)
        {
            FinalTouchposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            CalculateAngle();
        }
    }

    void CalculateAngle()
    {
        if (Mathf.Abs(FinalTouchposition.y - FirstTouchPosition.y) > SwipeResist || Mathf.Abs(FinalTouchposition.x - FirstTouchPosition.x) > SwipeResist)
        {
            SwipeAngle = Mathf.Atan2(FinalTouchposition.y - FirstTouchPosition.y, FinalTouchposition.x - FirstTouchPosition.x) * 180 / Mathf.PI;
            MovePieces();
            enemyaction.Action();
            board.currentState = GameState.wait;
        }
        else
        {
            board.currentState = GameState.move;
        }
    }

    void MovePieces()
    {
        if (SwipeAngle > -45 && SwipeAngle <= 45 && Column < board.width - 1) //right Swipe
        {
            OtherDot = board.allDots[Column + 1, Row];
            preColumn = Column;
            preRow = Row;
            OtherDot.GetComponent<Dot>().Column -= 1;
            Column += 1;
        }
        else if (SwipeAngle > 45 && SwipeAngle <= 135 && Row < board.height - 1) //Up Swipe
        {
            OtherDot = board.allDots[Column, Row + 1];
            preColumn = Column;
            preRow = Row;
            OtherDot.GetComponent<Dot>().Row -= 1;
            Row += 1;
        }
        else if ((SwipeAngle > 135 || SwipeAngle <= -135) && Column > 0) //Left Swipe
        {
            OtherDot = board.allDots[Column - 1, Row];
            preColumn = Column;
            preRow = Row;
            OtherDot.GetComponent<Dot>().Column += 1;
            Column -= 1;

        }
        else if (SwipeAngle < -45 && SwipeAngle >= -135 && Row > 0) //Down Swipe
        {
            OtherDot = board.allDots[Column, Row - 1];
            preColumn = Column;
            preRow = Row;
            OtherDot.GetComponent<Dot>().Row += 1;
            Row -= 1;
        }
        StartCoroutine(CheckMoveCo());
    }

    void Findmatches()
    {
        Debug.Log("FIND THIS");
        if (Column > 0 && Column < board.width - 1)
        {
            GameObject leftDot1 = board.allDots[Column - 1, Row];
            GameObject rightDot1 = board.allDots[Column + 1, Row];
            if (leftDot1 != null && rightDot1 != null)
                if (leftDot1.tag == this.gameObject.tag && rightDot1.tag == this.gameObject.tag)
                {
                    leftDot1.GetComponent<Dot>().isMatched = true;
                    rightDot1.GetComponent<Dot>().isMatched = true;
                    isMatched = true;
                }
        }
        if (Row > 0 && Row < board.height - 1)
        {
            GameObject upDot1 = board.allDots[Column, Row + 1];
            GameObject downDot1 = board.allDots[Column, Row - 1];
            if (upDot1 != null && downDot1 != null)
                if (upDot1.tag == this.gameObject.tag && downDot1.tag == this.gameObject.tag)
                {
                    upDot1.GetComponent<Dot>().isMatched = true;
                    downDot1.GetComponent<Dot>().isMatched = true;
                    isMatched = true;
                }
        }
    }
}
