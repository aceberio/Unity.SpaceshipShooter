using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [field: SerializeField] private float Speed { get; set; }
    [field: SerializeField] private GameObject LowerObject { get; set; }

    private void Update()
    {
        transform.position += new Vector3(0, Speed * Time.deltaTime, 0);

        if (transform.position.y <= -10)
            transform.position = LowerObject.transform.position + new Vector3(0, 10, 0);
    }
}
