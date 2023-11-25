using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animation _animation;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        _animation.Runing();
    }
}
