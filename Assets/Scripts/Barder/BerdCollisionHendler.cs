using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BerdCollisionHendler : MonoBehaviour
{
    private Berd _berd;
    private void Start()
    {
        _berd = GetComponent<Berd>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out ScoreSone scoreSone))
            _berd.ScoreCount();
        
        else
        _berd.Die();
    }
}
