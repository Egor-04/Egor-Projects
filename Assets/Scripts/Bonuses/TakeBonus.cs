using UnityEngine;

namespace GameController
{
    public class TakeBonus : MonoBehaviour, IBonus
    {
        [Header("Points")]
        [SerializeField] private int Points;

        [HideInInspector]
        [SerializeField] private GameController _gameController;

        [HideInInspector]
        [SerializeField] private GameVictoryController _gameVictoryController;

        private void Start()
        {
            _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                _gameVictoryController = _gameController.GameVictory;
                gameObject.GetComponent<IBonus>().Take();
                _gameController.CountText.text = "Require Bonus Count: " + _gameVictoryController.RequireCount;
            }
        }

        public void Take()
        {
            Debug.Log("Taked: " + _gameVictoryController);
            _gameVictoryController.RequireCount += Points;
            Destroy(gameObject);
        }
    }
}