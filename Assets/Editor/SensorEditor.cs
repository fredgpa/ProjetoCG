using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Sensor))]
public class SensorEditor : Editor
{
    void OnSceneGUI()
    {
        Sensor sense = (Sensor)target;
        Handles.color = Color.white;
        Handles.DrawLine(sense.Receptor1.transform.position, sense.Receptor2.transform.position);
    }
}
