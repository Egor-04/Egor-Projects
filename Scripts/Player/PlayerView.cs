using UnityEngine;

namespace GameController
{
    public class PlayerView : MonoBehaviour, IUpdatable, IFixedUpdatable
    {
        [SerializeField] private PlayerModel _playerModel;
    
        private PlayerController _playerController;
    
        private void Start()
        {
            _playerController = new PlayerController(_playerModel.Speed, _playerModel.JumpForce, _playerModel.PlayerHealth, gameObject);
        }
    
    
        public void UpdateTick()
        {
            _playerController.UpdateTick();
        }
    
        public void FixedTick()
        {
            _playerController.FixedTick();
        }
    }
}