using UnityEngine.SceneManagement;
using UnityEngine;

namespace GameController
{
    public class UIController : MonoBehaviour
    {
        public void ReloadScene(string nameScene)
        {
            SceneManager.LoadScene(nameScene);

            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    
    }
}
