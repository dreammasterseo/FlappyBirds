using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BarderMover))]
public class Berd : MonoBehaviour
{
    public event UnityAction GameOwer;
    private BarderMover _barderMover;
    private int _score;
    public event UnityAction<int> ScoreCanget;
    private void Start()
    {
        _barderMover = GetComponent<BarderMover>();
    }

    public void ResetOlayer()
    {
        _score = 0;
        ScoreCanget?.Invoke(_score);
        _barderMover.ResetBerd();
    }

    public void Die()
    {
        GameOwer?.Invoke();
    }

    public void ScoreCount()
    {
        _score++;
        ScoreCanget?.Invoke(_score);
    }
}
