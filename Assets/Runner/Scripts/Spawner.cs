using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _prefabTembplast;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elepsedTime = 0;

    private void Start()
    {
        Inirialize(_prefabTembplast);
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elepsedTime = 0;
                int SpawnPointNumber = Random.Range(0, _spawnPoints.Length);

                SetWave(enemy, _spawnPoints[SpawnPointNumber].position);

            }
        }
    }

    private void SetWave(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
