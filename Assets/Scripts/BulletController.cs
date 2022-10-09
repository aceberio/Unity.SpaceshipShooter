using UnityEngine;

public class BulletController : MonoBehaviour
{
    [field: SerializeField] private float Speed { get; set; }

    private void Start() => Destroy(gameObject, 5f);

    private void Update() => transform.position += new Vector3(0, Speed * Time.deltaTime, 0);

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Enemy") return;
        collision.gameObject.GetComponentInParent<EnemyController>().Health--;
        Destroy(gameObject);
    }
}
