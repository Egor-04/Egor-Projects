using UnityEngine;
using UnityEngine.UI;

namespace GameController
{
    public class TrapView : IUpdatable
    {
        [Header("Panel")]
        public GameObject _panelGameOver;
        public GameObject _trapObject;

        private TrapController _trapController;

        public void UpdateTick()
        {
            _trapController.UpdateTick();
        }
    }
}
