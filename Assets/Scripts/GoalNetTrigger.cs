using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalNetTrigger : MonoBehaviour
{

    private Collider expectedCollider;

    public TMP_Text question;
    public TMP_Text option1;
    public TMP_Text option2;
    public TMP_Text option3;

    public GameObject coins;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (expectedCollider == other)
        {
            if (other.CompareTag("Ball")) {
                BallState ball = other.GetComponent<BallState>();

				ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
				scoreKeeper.incremenetScore(ball.getPointValue());

                question.text = "What is the average anualized return in mutual funds";
                option1.text = "9.5%";
                option2.text = "10%";
                option3.text = "12%";

                coins.SetActive(true);

                /*MovePlayer movePlayer = FindObjectOfType<MovePlayer>();
				movePlayer.MoveToRandomPosition();*/

            } else {
                print("NOT BALL :/  --> " + other.tag);
            }
        }
    }
}