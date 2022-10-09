using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private float _timer;

    public int Score { get; set; }
    [field: SerializeField] private Vector3 Movement { get; set; }
    [field: SerializeField] private float Speed { get; set; }
    [field: SerializeField] private GameObject Bullet { get; set; }
    [field: SerializeField] private float FireRate { get; set; }
    [field: SerializeField] private Text ScoreText { get; set; }


    private void Update()
    {
        Movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        transform.position += Movement * (Speed * Time.deltaTime);

        if (Input.GetKey("space") && _timer <= 0)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);

            _timer = FireRate;
        }

        _timer -= Time.deltaTime;

        ScoreText.text = $"{Score}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Enemy") return;
        const string sceneName = "Scene01";
        SceneManager.LoadScene(sceneName);
    }
}