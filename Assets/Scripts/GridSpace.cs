using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    //public string playerSide;

    private GameController gameController;


    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetSpace()
    {
        //buttonText.text = playerSide;
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
