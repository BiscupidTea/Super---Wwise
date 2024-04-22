using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AkGameObj))]
public class SwEventAudio : MonoBehaviour
{
    //string event 
    [SerializeField] private string EventName;

    //colision
    [SerializeField] private bool collider;
    private bool triggerColissionEnter;
    private bool triggerColissionExit;
    private Collider colliderProvided;

    private void OnEnable()
    {
        if (collider)
        {
            if (gameObject.GetComponent<Collider>())
            {
                colliderProvided = gameObject.GetComponent<Collider>();
            }
            else
            {
                Debug.LogError("SwEventAudio: " + gameObject.name + " = Can't find component " + "COLLIDER");
            }
        }
    }

    private void OnDisable()
    {

    }

    private void OnPlayAudio()
    {
        AkSoundEngine.PostEvent(EventName, gameObject);
    }

    private void OnValidate()
    {
        if (collider)
        {
            
        }
    }
}
