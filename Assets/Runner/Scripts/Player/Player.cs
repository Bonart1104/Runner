using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;
    private int _maxHealth = 6;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    public void ApplyDamage(int damaged)
    {
        _health -= damaged;

        HealthChanged?.Invoke(_health);

        if (_health <= 0)
        {
            Die();
        }
    }

    public void ApplyHeal(int healPoint)
    {
        if (_health <= _maxHealth)
        {
            _health += healPoint;
            HealthChanged?.Invoke(_health);
        }
    }

    public void Die()
    {
        Died?.Invoke();
    }
}
