using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float _timer;
    [field: SerializeField] private GameObject Enemy { get; set; }
    [field: SerializeField] private float SpawnInterval { get; set; }

    private void Update()
    {
        if (_timer <= 0)
        {
            Instantiate(Enemy, new Vector3(0, 4.2f, 0), Quaternion.identity);
            _timer = SpawnInterval;
        }

        _timer -= Time.deltaTime;
    }
}