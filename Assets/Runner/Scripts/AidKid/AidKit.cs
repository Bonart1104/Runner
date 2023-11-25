using UnityEngine;

public class AidKit : MonoBehaviour
{
    [SerializeField] private int _healthPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyHeal(_healthPoints);
        }

        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}

