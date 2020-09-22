using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaySomething : MonoBehaviour
{
    public string[] Text;
    public GameObject Dialogue;
    public GameObject Player;
    public GameObject tipFromGranny;
    public TextMeshProUGUI TextBox;
    public bool isHere = true;
    public int dialogueCheck;

    void Update()
    {
        if(Dialogue.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                TextBox.text = Text[dialogueCheck];
                dialogueCheck++;
            }
        }
        if (dialogueCheck == Text.Length)
        {
            dialogueCheck = 0;  
        }
        if (Input.GetKeyDown(KeyCode.E) && isHere == true)
        {
            TextBox.text = Text[dialogueCheck];
            Dialogue.gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.R) || isHere == false)
        {
            Dialogue.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player.gameObject)
        {
            isHere = true;
            tipFromGranny.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player.gameObject)
        {
            isHere = false;
            tipFromGranny.SetActive(false);
        }
    }
}
