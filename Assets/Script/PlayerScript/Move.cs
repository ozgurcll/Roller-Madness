using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Move: MonoBehaviour
{
    private Vector3 movement;
    private float x;
    private float y;
    public int speed = 5;
    public Rigidbody rb;
    public Transform cam;
    public TimeManager timeManager;
    public List<GameObject> destroyAfterGame = new List<GameObject>();
    public Text scoreText;
    public Text currentMoneytext;
    private void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
    }
    void Update()
    {
        if(timeManager.win == false)
        {
            PlayerMove();
        }

        if(timeManager.win == true)
        {
            rb.isKinematic = true;
        }
    }
    private void PlayerMove()
    {
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        movement = new Vector3(x, 0, y);

        transform.position += movement;
    }

   
    private void OnTriggerEnter(Collider other)
    {
        Score score = FindObjectOfType<Score>();


        if (other.CompareTag("BadDoor"))
        {
            speed--;
            foreach (Score puan in FindObjectsOfType<Score>())
            {
                puan.score--;
                scoreText.text = "Puan: " + puan.score;
            }
            foreach (Enemyy enemy in FindObjectsOfType<Enemyy>())
            {
                enemy.speed -= 0.5f;
                enemy.stopDistance += 1f;
            }

        }
        else if (other.CompareTag("GoodDoor"))
        {
            speed++;
            foreach (Score puan in FindObjectsOfType<Score>())
            {
                puan.score++;
                scoreText.text = "Puan: " + puan.score;

            }
            foreach (Enemyy enemy in FindObjectsOfType<Enemyy>())
            {
                enemy.speed += 0.5f;
            }

        }

        if (score.score == 1 && other.gameObject.CompareTag("GG"))
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();


           timeManager.win = true;
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            timeManager.winPanel.SetActive(true);
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
            score.currentMoney = score.money * score.score;
            currentMoneytext.text = score.currentMoney.ToString();
        }

        if (score.score == 2 && other.gameObject.CompareTag("GG1"))
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();


            timeManager.win = true;
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            timeManager.winPanel.SetActive(true);

            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
            score.currentMoney = score.money * score.score;
            currentMoneytext.text = score.currentMoney.ToString();
        }

        if (score.score == 3 && other.gameObject.CompareTag("GG2"))
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();


            timeManager.win = true;
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            timeManager.winPanel.SetActive(true);
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
            score.currentMoney = score.money * score.score;
            currentMoneytext.text = score.currentMoney.ToString();
        }

        if (score.score == 4 && other.gameObject.CompareTag("GG3"))
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();


            timeManager.win = true;
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            timeManager.winPanel.SetActive(true);
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
            score.currentMoney = score.money * score.score;
            currentMoneytext.text = score.currentMoney.ToString();
            Debug.Log(score.currentMoney);
        }

        if (score.score == 5 && other.gameObject.CompareTag("GG4"))
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();


            timeManager.win = true;
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            timeManager.winPanel.SetActive(true);
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
            score.currentMoney = score.score * score.money;
            currentMoneytext.text = score.currentMoney.ToString();
        }

        if (score.score == 6 && other.gameObject.CompareTag("GG5"))
        {
            TimeManager timeManager = FindObjectOfType<TimeManager>();


            timeManager.win = true;
            UpdateObjectList("Enemy");
            UpdateObjectList("Object");
            timeManager.winPanel.SetActive(true);
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }
            score.currentMoney = score.score * score.money;
            currentMoneytext.text = score.currentMoney.ToString();
        }


    }

    void UpdateObjectList(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag));
    }

}
