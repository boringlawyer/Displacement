using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonHelper : MonoBehaviour
{
    public void OnPress() 
    {
        EventSystem.StartGame();
    }
}
