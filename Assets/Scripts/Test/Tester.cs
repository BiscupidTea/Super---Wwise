using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tester : MonoBehaviour
{
    public UnityEvent testEvent;
    public SwUnityEventSubscriber testSubscriber;

    private void OnEnable()
    {
        testSubscriber.OnPlayAudioEvent.AddListener(ReceivedEvent);
    }

    private void OnDisable()
    {
        testSubscriber.OnPlayAudioEvent.RemoveListener(ReceivedEvent);
    }

    [ContextMenu("Test Event")]
    public void TestEvent()
    {
       testEvent.Invoke();
    }

    public void ReceivedEvent()
    {
        Debug.Log("Recived Event");
    }
}
