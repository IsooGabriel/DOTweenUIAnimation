using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = false; // 編集不可にする
        EditorGUI.PropertyField(position, property, label);
        GUI.enabled = true;  // 元に戻す
    }
}