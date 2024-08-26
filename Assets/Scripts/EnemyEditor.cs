using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Enemy))]
public class EnemyEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Enemy myTarget = (Enemy)target;

        if(GUILayout.Button("Button Test EDITOR"))
        {
            myTarget.TestEditor();
        }
    }
}
