using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SwUnityEventSubscriber))]
public class EventAudioEditor: Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SwUnityEventSubscriber BaseAudioScript = (SwUnityEventSubscriber)target;

        if (GUILayout.Button("Play Audio"))
        {
            BaseAudioScript.OnPlayAudio();
        }
    }
}
