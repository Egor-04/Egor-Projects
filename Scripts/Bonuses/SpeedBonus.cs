using UnityEngine;

namespace GameController
{
    public class SpeedBonus : MonoBehaviour
    {
        [Header("Speed & Time")]
        [SerializeField] private float _actionTimer;
        [SerializeField] private float _superSpeed;
    
        [Header("Initial")]
        [SerializeField] private float _initialSpeed;
    
        [Header("Current")]
        [SerializeField] private float _currentTimer;
        [SerializeField] private float _currentSpeed;
    
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                collider.gameObject.GetComponent<PlayerView>();
            }
        }
    }
}
