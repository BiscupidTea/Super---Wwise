using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class SwBasic : MonoBehaviour
{
    //string event 
    public string eventName;

    //others
    public UnityEvent onPlayAudioEvent;

    public void OnPlayAudio()
    {
        Debug.Log("Play Audio");
        AkSoundEngine.PostEvent(eventName, gameObject);
    }
}