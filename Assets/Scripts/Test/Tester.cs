using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tester : MonoBehaviour
{
    public UnityEvent testEvent;

    [ContextMenu("Test Event")]
    public void TestEvent()
    {
       testEvent.Invoke();
    }
}
