using UnityEngine;

public class CameraAnda : MonoBehaviour
{

    public float velocidade;
    void Start()
    {
        velocidade = 5f;
    }

    void Update()
    {
        transform.position += new Vector3(1 * velocidade * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D player)
    {
        if(player.gameObject.CompareTag("Player"))
        {
            KillPlayer(player.gameObject);
        }
    }
    private void KillPlayer(GameObject player)
    {
        Destroy(player);
        Time.timeScale = 0;
    }
}
