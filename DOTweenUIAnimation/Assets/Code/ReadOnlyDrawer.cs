using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = false; // �ҏW�s�ɂ���
        EditorGUI.PropertyField(position, property, label);
        GUI.enabled = true;  // ���ɖ߂�
    }
}