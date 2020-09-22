using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairsAvability : MonoBehaviour
{
    public Vector3[] tabChairs;
    public bool[] tabChairsAvability;
    private int _myChair;
    public GameObject partner;

    void Start()
    {

    }

    public Vector3 CheckMyChair(int pickedChair)
    {
        if(tabChairsAvability[pickedChair] == true)
        {
            Debug.Log("Spoko, tu można");
            tabChairsAvability[pickedChair] = false;
            return tabChairs[pickedChair];
        }
        else if(tabChairsAvability[pickedChair] == false)
        {
            Debug.Log("Oj nie nie byczku, tu nie można");
            for(int i = 0; i < tabChairsAvability.Length - 1; i++)
            {
                if(tabChairsAvability[i] == true)
                { 
                    pickedChair = i;
                    tabChairsAvability[pickedChair] = false;
                    Debug.Log(pickedChair + " to Twoje nowe krzesło");
                    return tabChairs[pickedChair];
                }
            }
        }
        return tabChairs[pickedChair];
    }
}
