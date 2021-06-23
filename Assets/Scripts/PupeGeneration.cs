using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PupeGeneration : ObjectPool
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _seconds;
    [SerializeField] private float _maxPositionY;
    [SerializeField] private float _minPositionY;

    private float _elepseTime = 0;

    private void Start()
    {
        Inizilization(_prefab);
    }

    private void Update()
    {
        _elepseTime += Time.deltaTime;

        if(_elepseTime > _seconds)
        {
            if(TryGetObgect(out GameObject pipe))
            {
                _elepseTime = 0;
                float positionY = Random.Range(_minPositionY, _maxPositionY);
                Vector3 spawnPoint = new Vector3(transform.position.x, positionY, transform.position.z);
                pipe.SetActive(true);
                pipe.transform.position = spawnPoint;

                DisebleObject();
            }
        }
    }
}
