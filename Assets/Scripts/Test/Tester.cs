using UnityEngine;
using UnityEngine.Events;

public class Tester : MonoBehaviour
{
    public SwBasic swBasic;
    public SwSwitch swSwitch;
    public string newState;

    [ContextMenu("Test Event")]
    public void TestEvent()
    {
        swBasic.OnPlayAudio();
    }

    [ContextMenu("ChangeState Event")]
    public void ChangeState()
    {
        swSwitch.SetSwitchState(newState);
    }
}
