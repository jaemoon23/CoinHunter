using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public float destroyTimer;
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerController>();
            player.GameOver();
        }
        else if (other.CompareTag("Plane"))
        {
            Destroy(gameObject);
        }
    }
}
