/*
 * File:        SerializableDecimalDrawer.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class SerializableDecimalDrawer implements a PropertyDrawer for the SerializableDecimal class
 *              Based on https://answers.unity.com/questions/808352/how-to-make-decimal-variables-visible-in-inspector.html
 * Created:     05.10.2018
 */
using UnityEngine;
using UnityEditor;
using RotoChips.Utility;

[CustomPropertyDrawer(typeof(SerializableDecimal))]
public class SerializableDecimalDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        EditorGUI.BeginChangeCheck();
        SerializedProperty dataProperty = property.FindPropertyRelative("data");
        Rect fieldRect = EditorGUI.PrefixLabel(position, label);
        string text = GUI.TextField(fieldRect, dataProperty.stringValue);
        //string text = EditorGUI.TextField(fieldRect, dataProperty.stringValue);
        if (EditorGUI.EndChangeCheck())
        {
            decimal val;
            if (decimal.TryParse(text, out val))
            {
                dataProperty.stringValue = text;
                property.serializedObject.ApplyModifiedProperties();
            }
        }
        EditorGUI.EndProperty();
    }
}
