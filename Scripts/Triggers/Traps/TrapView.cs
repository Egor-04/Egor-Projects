using UnityEngine;


namespace GameController
{
    public class TrapView : MonoBehaviour
    {
        private GameController _gameController;

        private void Start()
        {
            _gameController = GameObject.FindObjectOfType<GameController>().GetComponent<GameController>();    
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
    
                _gameController._panelGameOver.SetActive(true);
            }
        }
    }
}