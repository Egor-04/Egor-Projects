using UnityEngine;

[ExecuteInEditMode]
public class FullCollider : MonoBehaviour
{
    [SerializeField] private Color _color;

    private BoxCollider _boxCollider;

    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        Gizmos.DrawCube(_boxCollider.transform.position, _boxCollider.size);
    }
}
