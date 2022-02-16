using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball gameBall;
    public Ball prefab;
    public Paddle paddle;
    public static bool startGame;
    public static bool started;
    public Text GameOverScreen;
    public int counter;
   

    // Start is called before the first frame update
    void Start()
    {
        
        InitBall();
    }

    // Update is called once per frame
    void Update()
    {
        Win();
        PreGame();
        Lose();
       
    }

    void PreGame()
    {
         Vector3 PaddlePos = paddle.gameObject.transform.position;
        Vector3 BallPos = new Vector3(PaddlePos.x, PaddlePos.y + 0.25f, 0);

        if (Input.GetMouseButtonDown(0))
        {
            startGame = true;
        }

        if (!startGame)
        {
            gameBall.transform.position = BallPos;
        }
    }

    void Win()
    {
        GameObject[] bricks;
        bricks = GameObject.FindGameObjectsWithTag("Brick");
        counter = bricks.Length;

        if (counter ==0)
        {
            GameOverScreen.text = "YOU'RE A WINNER!";
        }


    }

    void Lose()
    {
        if(gameBall == null)
        {
            GameOverScreen.text = "SORRY YOU LOST";
        }
    }

    void InitBall()
    {
        Vector3 PaddlePos = paddle.gameObject.transform.position;
        Vector3 BallPos = new Vector3(PaddlePos.x, PaddlePos.y + 0.25f, 0);

        gameBall = Instantiate(prefab, BallPos, Quaternion.identity);
    }
}
