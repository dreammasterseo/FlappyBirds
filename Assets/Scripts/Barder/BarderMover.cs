using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BarderMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _tapForce = 10;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _maxRotationZ;
    [SerializeField] private float _minRotationZ;

    private Rigidbody2D _rigidbody2D;
    private Quaternion _maxRotation;
    private Quaternion _minxRotation;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
       
        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minxRotation = Quaternion.Euler(0, 0, _minRotationZ);

        ResetBerd();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rigidbody2D.velocity = new Vector2(_speed, 0);
            transform.rotation = _maxRotation;
            _rigidbody2D.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, _minxRotation, _rotationSpeed * Time.deltaTime);
    }
  
    public void ResetBerd()
    {
        transform.position = _startPosition;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _rigidbody2D.velocity = Vector2.zero;
    }
}
