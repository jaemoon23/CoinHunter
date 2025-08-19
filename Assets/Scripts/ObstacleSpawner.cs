using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject FallingObstaclePreFab;

    public float spawnRateMin;
    public float spawnRateMax;

    private float random;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
        random = Random.Range(spawnRateMin, spawnRateMax);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > random)
        {
            Vector3 coinPos = new Vector3(Random.Range(-3, 3), 5f, Random.Range(-3, 3));
            var newCoin = Instantiate(FallingObstaclePreFab, coinPos, Quaternion.identity);

            timer = 0f;
            random = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
