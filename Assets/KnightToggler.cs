using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightToggler : MonoBehaviour {

    public GameObject framedKnight, standingKnight;

    public void ToggleKnight()
    {

        if (framedKnight.activeSelf)
        {
            framedKnight.SetActive(false);
            standingKnight.SetActive(true); 
        }
        else
        {
            standingKnight.SetActive(false);
            framedKnight.SetActive(true); 
        }
    }
}
