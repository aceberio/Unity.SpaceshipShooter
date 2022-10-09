using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    [field: SerializeField] private float RotationSpeed { get; set; }
    [field: SerializeField] private float DownSpeed { get; set; }
    [field: SerializeField] private GameObject Enemy { get; set; }
    [field: SerializeField] public int Health { get; set; }


    private void Start()
    {
        int localScaleX = Random.Range(0, 2) == 0 ? 1 : -1;
        transform.localScale = new Vector3(localScaleX, 1, 1);
    }

    private void Update()
    {
        Enemy.transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
        transform.position += new Vector3(0, DownSpeed * Time.deltaTime, 0);

        if (Health <= 0)
        {
            GameObject.Find("Character").GetComponent<CharacterController>().Score++;
            Destroy(gameObject);
        }
    }
}
