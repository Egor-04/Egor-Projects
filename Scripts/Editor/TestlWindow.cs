using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class TestWindow : EditorWindow
{
    public static GameObject ObjectInstantiate;
    public string _nameObject;
    public bool _groupEnabled;
    public bool _randomColor = true;
    public int _countObject = 1;
    public float _radius = 10;


    private void OnGUI()
    {
        GUILayout.Label("Заголовок", EditorStyles.boldLabel);
        _nameObject = EditorGUILayout.TextField("Имя Объекта", _nameObject);

        GUILayout.Label("Базовые настройки", EditorStyles.boldLabel);
        ObjectInstantiate = EditorGUILayout.ObjectField("Объект для редактирования", ObjectInstantiate, typeof(GameObject), true) as GameObject;

        _groupEnabled = EditorGUILayout.BeginToggleGroup("Дополнительные настройки", _groupEnabled);

        _randomColor = EditorGUILayout.Toggle("Случайный цвет", _randomColor);

        _countObject = EditorGUILayout.IntSlider("Количество объектов", _countObject, 1, 100);
        _radius = EditorGUILayout.Slider("Радиус окружности", _radius, 10, 50);
        EditorGUILayout.EndToggleGroup();

        var button = GUILayout.Button("Создать объекты");

        if (button)
        {
            if (ObjectInstantiate)
            {
                
                Vector3 position = new Vector3();
                Quaternion rotation = new Quaternion();

                Instantiate(ObjectInstantiate, position, rotation);
            }
        }
    }
}
