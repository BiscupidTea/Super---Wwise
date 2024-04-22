using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(EventAudio))]
public class EventAudioVisual : Editor
{
    public VisualTreeAsset visualTree;

    public override VisualElement CreateInspectorGUI()
    {
        VisualElement element = new VisualElement();

        visualTree.CloneTree(element);

        return element;
    }
}
