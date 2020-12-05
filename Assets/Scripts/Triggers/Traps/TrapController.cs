using UnityEngine;


namespace GameController
{
    public class TrapController : IUpdatable
    {
        private TrapView _trapView;
        public TrapController (GameObject panelGameOver, GameObject trapObject)
        {
            _trapView._panelGameOver = panelGameOver;
            _trapView._trapObject = trapObject;
        }

        #region UnityMethods 

        public void UpdateTick()
        {
            
        }
        
        public void OnDrawGizmos()
        {
            Gizmos.DrawCube(_trapView._trapObject.transform.position , _trapView._trapObject.transform.position);
        }

        #endregion
    }
}
