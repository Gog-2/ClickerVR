using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Vector3 _direction = Vector3.forward;
    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        if (rb != null)
        {
            rb.linearVelocity = _direction.normalized * _speed;
        }
    }
}
