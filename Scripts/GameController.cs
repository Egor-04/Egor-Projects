using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

namespace GameController
{
    public sealed class GameController : MonoBehaviour
    {
        [Header("Required Bonus")]
        public Text CountText;
        public GameVictoryController GameVictory;

        [Header("Traps")]
        public GameObject PanelGameOver;

        [Header("Player Camera")]
        [SerializeField] private GameObject _camera;
    
        [Header("Player")]
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private Transform _spawnPoint;

        [Header("Sphere Trigger")]
        [SerializeField] private float _radius;
        [SerializeField] private Transform _center;
        [SerializeField] private GameObject _panelWin;
        
        private Transform _playerPosition;
        private List<IUpdatable> _updatables = new List<IUpdatable>();
        private List<IFixedUpdatable> _fixedUpdatables = new List<IFixedUpdatable>();

        private void Start()
        {
            try
            {
                Instantiate(_camera, _spawnPoint.transform.position, Quaternion.identity);
                var player = Instantiate(_playerPrefab, _spawnPoint.position, Quaternion.identity);
                var playerView = player.GetComponent<PlayerView>();
                _playerPosition = player.transform;

                GameVictory = new GameVictoryController(_center, _radius, _panelWin);

                _updatables.Add(GameVictory);
                _updatables.Add(playerView);
                _fixedUpdatables.Add(playerView);
                _updatables.Add(new CameraController(_playerPosition, _camera.transform));
            }
            catch (UnassignedReferenceException missingObject)
            {
                Debug.Log("Перейдите к скрипту GameController, который висит на объекте GameController, там отсутвует вот этот объект -----> " + missingObject);
            }
        }

        private void Update()
        {
            foreach (var updatable in _updatables)
            {
                updatable.UpdateTick();
            }
        }
    
        private void FixedUpdate()
        {
            foreach (var fixedUpdatable in _fixedUpdatables)
            {
                fixedUpdatable.FixedTick();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0f, 20f, 0f);
            Gizmos.DrawWireSphere(_center.position, _radius);
        }
    }
}
