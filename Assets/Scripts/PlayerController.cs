using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public Rigidbody body;
    public float speed;

    private int CoinCount = 0;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(h, 0f, v);
        if (velocity.magnitude > 1f)
        {
            velocity.Normalize();
        }
        velocity *= speed;

        body.linearVelocity = velocity;
    }

    public void GameOver()
    {
        gameObject.SetActive(false);
    }

    public void GetCoin()
    {
        CoinCount++;
    }
}
