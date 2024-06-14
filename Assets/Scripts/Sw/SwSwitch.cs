using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwSwitch : MonoBehaviour
{
    public string SwitchGroup;

    public void SetSwitchState(AK.Wwise.Switch newState)
    {
        AkSoundEngine.SetSwitch(SwitchGroup, newState.ToString(), gameObject);
    }

    public void SetSwitchState(string newState)
    {
        AkSoundEngine.SetSwitch(SwitchGroup, newState, gameObject);
    }
}
