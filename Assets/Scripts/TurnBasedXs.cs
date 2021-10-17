using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class TurnBasedXs : MonoBehaviour
{
    public GameObject Heal;
    public GameObject Attack;
    public int xHealth = 40;
    public int oHealth = 50;
    public Text playerOHealth;
    public Text playerXHealth;
    public Text turnString;
    public int turn = 1;


    public string oHealthTextO = "";
    // Start is called before the first frame update

    void Awake()
    {
        turn = 1;
        xHealth = 40;
        oHealth = 50;
        playerOHealth.text = "Your health is " + oHealth;
        playerXHealth.text = "Your health is " + xHealth;
    }

    void Start()
    {
        //turn = 0; 
        //xHealth = 40;
        //oHealth = 50;
        //playerOHealth.text = "Your health is " + oHealth;
        // playerXHealth.text = "Your health is " + xHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
    public class Player
    {
        public Image panel;
        public Text text;
        public Button button;
    }

    public void OnClickOFight()
    {


        if (xHealth != 0 || oHealth != 0)
        {
            if (turn % 2 == 0)
            {
                turnString.text = "O decided to attack";
                oHealth -= Random.Range(0, 20);
                if (oHealth < 0)
                {
                    oHealth = 0;
                    playerOHealth.text = "X health is 0, you lost this fight";
                    SceneManager.LoadScene("SampleScene");

                }
                playerOHealth.text = "Your health is " + oHealth;
                turn++;
                turnString.text = "What will X's do";
            }
            else
            {
                turnString.text = "X decided to attack";
                xHealth -= Random.Range(0, 15);
                playerXHealth.text = "Your health is " + xHealth;
                turn++;
                turnString.text = "What will O's do";
            }
        }
        else if (xHealth < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (oHealth < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }


    }


    public void OnClickHeal()
    {
        if (xHealth != 0 || oHealth != 0)
        {
            if (turn % 2 == 0)
            {
                Heal.SetActive(false);
                Attack.SetActive(false);
                turnString.text = "O decided to Heal";
                oHealth += Random.Range(0, 10);
                playerOHealth.text = "Your health is " + xHealth;
                turn++;
                Heal.SetActive(true);
                Attack.SetActive(true);
                turnString.text = "What will X's do";

            }
            else
            {
                Heal.SetActive(false);
                Attack.SetActive(false);
                turnString.text = "X decided to Heal";
                xHealth += Random.Range(0, 10);
                playerXHealth.text = "Your health is " + oHealth;
                turn++;
                Heal.SetActive(true);
                Attack.SetActive(true);
                turnString.text = "What will O's do";
            }
        }
        else if (xHealth < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (oHealth < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
