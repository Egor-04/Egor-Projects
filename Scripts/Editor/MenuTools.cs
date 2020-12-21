using UnityEditor;
using UnityEngine;


public class MenuTools : MonoBehaviour
{
    [MenuItem("EditorWindows/ObjectController")]
    private static void OpenObjectControllerWindow()
    {
        EditorWindow.GetWindow<ObjectController>();
    }

    [MenuItem("EditorWindows/TestEditor")]
    private static void OpenSphereEditor()
    {
        EditorWindow.GetWindow<TestWindow>();
    }

    [MenuItem("TemplateOfObjects/Light")]
    private static void CreateLamp()
    {
        Instantiate(Resources.Load("Objects/Spot Light"));
        Debug.Log("Работает!");
    }
}

