using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(SwEventAudio))]
public class EventAudioEditor: Editor
{
    public VisualTreeAsset visualTree;

    public override VisualElement CreateInspectorGUI()
    {
        VisualElement element = new VisualElement();

        visualTree.CloneTree(element);

        return element;
    }
}
