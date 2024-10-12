using log4net.Util;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


[CustomEditor(typeof(RotatingAndBobbing))]

public class RotatingAndBobbingEditor : Editor
{
    private float _rotateMin = -90f;
    private float _rotateMax = 90f; 
    private float _bobMin = 0f;
    private float _bobMax = 5f;  
    private float _ampMin = 0f;
    private float _ampMax = 1f;
    public override void OnInspectorGUI()
    {
        RotatingAndBobbing _rotatingAndBobbing = (RotatingAndBobbing)target;
        GUILayout.Label("Rotating ", EditorStyles.boldLabel);
        _rotatingAndBobbing._rotateSpeed = Mathf.Clamp(_rotatingAndBobbing._rotateSpeed, _rotateMin, _rotateMax);
        _rotatingAndBobbing._rotateSpeed = EditorGUILayout.FloatField("Rotate speed", _rotatingAndBobbing._rotateSpeed);
        if (GUILayout.Button("Reset Rotating"))
        {
            _rotatingAndBobbing._rotateSpeed = 0f;
            _rotatingAndBobbing.transform.rotation = Quaternion.identity;
        }
        EditorGUILayout.Space();

        GUILayout.Label("Bobbing",EditorStyles.boldLabel);
         _rotatingAndBobbing._bobSpeed = EditorGUILayout.Slider("Bob speed", _rotatingAndBobbing._bobSpeed, _bobMin, _bobMax);
         _rotatingAndBobbing._amplitude = EditorGUILayout.Slider("Amplitude", _rotatingAndBobbing._amplitude, _ampMin, _ampMax);
        if (GUILayout.Button("Reset Bobbing"))
        {
            _rotatingAndBobbing._bobSpeed = 0f;
            _rotatingAndBobbing._amplitude = 0f;
           // _rotatingAndBobbing.transform.position = Vector3.zero;
        }

    }
}
