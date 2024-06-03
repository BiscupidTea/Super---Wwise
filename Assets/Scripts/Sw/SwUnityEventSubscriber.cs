using UnityEngine;
using UnityEngine.Events;

public class SwUnityEventSubscriber : MonoBehaviour
{
    //string event 
    [SerializeField] private string EventName;

    //others
    public UnityEvent OnPlayAudioEvent;

    //colision
    [SerializeField] private bool collider;
    [SerializeField] private bool ColissionEnter;
    [SerializeField] private bool ColissionExit;
    [SerializeField] private bool TiggerEnter;
    [SerializeField] private bool TriggerExit;

    public void OnPlayAudio()
    {
        AkSoundEngine.PostEvent(EventName, gameObject);
        OnPlayAudioEvent.Invoke();
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