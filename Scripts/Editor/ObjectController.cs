using System;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class ObjectController : EditorWindow
{
    public GameObject _object;
    public float _maxSpeed;
    public float _objectSpeedRotation;
    public string _passwordField;

    private int _truePassword = 1234;
    private bool _accessIsGranted;

    private void Update()
    {
        if (_object)
        {
            RotateObject(_object);
        }
    }

    private void OnGUI()
    {
        _passwordField = EditorGUILayout.PasswordField("Введите пароль разработчика: ", _passwordField);

        var passwordField = Convert.ToInt32(_passwordField);
        AccessGranted(passwordField);

        _accessIsGranted = EditorGUILayout.BeginToggleGroup("Доступ открыт", _accessIsGranted);
        _object = EditorGUILayout.ObjectField("Объект для управления", _object, typeof(GameObject), true) as GameObject;
        _maxSpeed = EditorGUILayout.Slider("Максимальная Скорость вращения", _maxSpeed, 0 , 100f);
        _objectSpeedRotation = EditorGUILayout.Slider("Скорость Вращения" , _objectSpeedRotation, 0f, _maxSpeed);
    }

    private void RotateObject(GameObject gameObject)
    {
        gameObject.transform.Rotate(0f , _objectSpeedRotation, 0f);
    }

    private void AccessGranted(int passwordField)
    {
        if (passwordField == _truePassword)
        {
            _accessIsGranted = true;
        }
        else
        {
            _accessIsGranted = false;
        }
    }
}
