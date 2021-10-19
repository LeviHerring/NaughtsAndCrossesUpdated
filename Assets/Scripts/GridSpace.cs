﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    //public string playerSide;

    private GameController gameController;

    private MainMenu mainMenu;

    private TurnBasedXs turnBasedXs;

    private TurnBasedFight turnBasedFight;

    // Start is called before the first frame update
    void Start()
    {

    }

     void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);
    }
    public void SetSpace()
    {
        if(gameController.GetPlayerSide() == "X")
        {
            SceneManager.LoadScene("X fight scene 1");
        //    if(gameObject.GetComponent<TurnBasedXs>().hasWon == true)
        //    {
        //        buttonText.text = gameController.GetPlayerSide();
        //        button.interactable = false;
        //        gameController.EndTurn();
        //    }
        //    else
        //    {
        //        buttonText.text = gameController.GetPlayerSide();
        //        button.interactable = false;
        //        gameController.EndTurn();
        //    }
        }
        else
        {
            SceneManager.LoadScene("O fight scene");
        //    if (gameObject.GetComponent<TurnBasedXs>().hasWon == true)
        //    {
        //        buttonText.text = gameController.GetPlayerSide();
        //        button.interactable = false;
        //        gameController.EndTurn();
        //    }
        //    else
        //    {
        //        gameController.EndTurn();
           //}
        }
        //buttonText.text = playerSide;

    }
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void WinTurnBased()
    {
        if (gameObject.GetComponent<TurnBasedXs>().hasWon == true)
        {
            buttonText.text = gameController.GetPlayerSide();
            button.interactable = false;
            gameController.EndTurn(); 
        }
        else
        {
            buttonText.text = gameController.GetPlayerSide();
            button.interactable = false;
            gameController.EndTurn();
        }

        Debug.Log("This Function is being passed through ");

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
