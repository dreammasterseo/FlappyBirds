using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Scoore : MonoBehaviour
{
    [SerializeField] private Berd _berd;
    [SerializeField] private TMP_Text _score;
    

    private void OnEnable()
    {
        _berd.ScoreCanget += OnScoreChange;
    }

    private void OnDisable()
    {
        _berd.ScoreCanget -= OnScoreChange;
    }

    private void OnScoreChange(int score)
    {
        _score.text = score.ToString();
    }
}
