using UnityEngine;

public class EventAudio : MonoBehaviour
{
    [SerializeField] private string EventName;

    private void Update()
    {
        Debug.Log(EventName);
    }
}
