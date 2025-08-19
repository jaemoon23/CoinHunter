using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPreFab;

    public float spawnRateMin;
    public float spawnRateMax;

    private float random;
    private float timer;
    
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
            Vector3 coinPos = new Vector3(Random.Range(-3, 3), 1f, Random.Range(-3, 3));
            var newCoin = Instantiate(CoinPreFab, coinPos, Quaternion.identity);

            timer = 0f;
            random = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
