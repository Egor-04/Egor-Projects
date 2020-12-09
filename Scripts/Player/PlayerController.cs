using UnityEngine;

public class PlayerController : IUpdatable, IFixedUpdatable
{
    private Rigidbody _rigidbody;
    private PlayerModel _playerModel;
    private Vector3 _movement;

    public PlayerController(float speed, float health, float jumpForce, GameObject player)
    {
        _playerModel = new PlayerModel();

        _playerModel.Speed = speed;
        _playerModel.PlayerHealth = health;
        _playerModel.JumpForce = jumpForce;
        _rigidbody = player.GetComponent<Rigidbody>();
    }

    public void UpdateTick()
    {
        _movement.z = Input.GetAxis("Vertical");
        _movement.x = Input.GetAxis("Horizontal");
    }

    public void FixedTick()
    {
        _movement = _movement * _playerModel.Speed;
        _movement.y = _rigidbody.velocity.y;
        _rigidbody.velocity = _movement;
    }


    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
