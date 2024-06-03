using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AkGameObj))]
public class UnityEventSubscriber : MonoBehaviour
{
    //string event 
    [SerializeField] private string EventName;

    //colision
    [SerializeField] private bool collider;
    [SerializeField] private bool ColissionEnter;
    [SerializeField] private bool ColissionExit;
    [SerializeField] private bool TiggerEnter;
    [SerializeField] private bool TriggerExit;

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    public void OnPlayAudio()
    {
        AkSoundEngine.PostEvent(EventName, gameObject);
    }

    #region Collisions and triggers
    private void OnCollisionEnter(Collision collision)
    {
        if (ColissionEnter)
        {
            OnPlayAudio();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (ColissionExit)
        {
            OnPlayAudio();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TiggerEnter)
        {
            OnPlayAudio();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (TriggerExit)
        {
            OnPlayAudio();
        }
    }
    #endregion
}