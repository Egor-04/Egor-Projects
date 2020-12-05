using UnityEngine;

public class CameraController : IUpdatable
{
    private Camera _camera;
    private Transform _player;
    private Transform _cameraPosition;
    
    public CameraController(Transform playerPosition, Transform cameraPosition)
    {
        _player = playerPosition;
        _cameraPosition = cameraPosition;
        var moveToCamera = _player.position - _cameraPosition.position;
        _camera = Camera.main;
    }

    public void UpdateTick()
    {
        _camera.transform.position = _player.position + _cameraPosition.position;
        _camera.transform.LookAt(_player);
    }
}
