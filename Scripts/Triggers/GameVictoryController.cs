using UnityEngine;


namespace GameController
{
    public class GameVictoryController : TakeBonus, IUpdatable
    {

        public int RequireCount;

        private float _radius;
        private Transform _center;
        private GameObject _panelWin;

        public GameVictoryController(Transform center, float radius, GameObject panelWin)
        {
            _center = center;
            _radius = radius;
            _panelWin = panelWin;
        }

        public void UpdateTick()
        {
            Collider[] hitColliders = Physics.OverlapSphere(_center.position, _radius);

            for (int i = 0; i < hitColliders.Length; i++)
            {
                if (hitColliders[i].gameObject.CompareTag("Player"))
                {
                    Debug.Log("You Win! You Count Bonuses: " + RequireCount);
                    if (RequireCount >= 50)
                    {
                        _panelWin.SetActive(true);
                    }
                }
            }
        }
    }
}