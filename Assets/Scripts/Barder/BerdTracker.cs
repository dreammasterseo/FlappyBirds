using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerdTracker : MonoBehaviour
{
    [SerializeField] private Berd _berd;
    [SerializeField] private float _zOffset;

    private void Update()
    {
        transform.position = new Vector3(_berd.transform.position.x - _zOffset, transform.position.y, transform.position.z);
    }
}
