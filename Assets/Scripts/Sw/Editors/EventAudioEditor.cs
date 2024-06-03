using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(UnityEventSubscriber))]
public class EventAudioEditor: Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        UnityEventSubscriber BaseAudioScript = (UnityEventSubscriber)target;

        if (GUILayout.Button("Play Audio"))
        {
            BaseAudioScript.OnPlayAudio();
        }
    }
}
