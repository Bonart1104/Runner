using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _healthDisplay;


    private void OnEnable()
    {
        _player.HealthChanged += OnHealtChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealtChanged;
    }

    private void OnHealtChanged(int health)
    {
        _healthDisplay.text = health.ToString();
    }
}
