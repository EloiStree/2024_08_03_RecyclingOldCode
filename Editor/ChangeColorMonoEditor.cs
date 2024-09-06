
using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ChangeColorMono))]
public class ChangeColorMonoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ChangeColorMono myScript = (ChangeColorMono)target;
        if (GUILayout.Button("Change Color"))
        {
            myScript.SwitchColor();
        }
    }
}