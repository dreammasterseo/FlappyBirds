using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _continer;
    [SerializeField] private int _capasity;

    private Camera _camera;
    private List<GameObject> _pool = new List<GameObject>();

    public void Inizilization(GameObject prefab)
    {
        _camera = Camera.main;
        for (int i = 0; i < _capasity; i++)
        {
           GameObject spawned = Instantiate(prefab,_continer.transform);
            spawned.SetActive(false);
            _pool.Add(spawned);
        }
    }

    protected void DisebleObject()
    {
        Vector3 point = _camera.ViewportToWorldPoint(new Vector2(0, 0.5f));
        for (int i = 0; i < _pool.Count; i++)
        {
            if (_pool[i].activeSelf == true)
            {
                if (_pool[i].transform.position.x < point.x)
                    _pool[i].SetActive(false);
            }
        }
    }

    protected bool TryGetObgect(out GameObject result)
    {
        result = _pool.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }

    public void ResetPool()
    {
        foreach (var item in _pool)
        {
            item.SetActive(false);
        }
    }
}
