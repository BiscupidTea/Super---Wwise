using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwState : MonoBehaviour
{
    public string stateGroup;
    
    public void SetState(string newState)
    {
        AkSoundEngine.SetState(stateGroup, newState);
    }
}
