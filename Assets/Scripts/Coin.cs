using UnityEngine;

public class Coin : MonoBehaviour
{
    public float destroyTimer;
    private void Start()
    {
        Destroy(gameObject, destroyTimer);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerController>();
            player.GetCoin();

        }
    }
}
