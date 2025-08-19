using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;

    public TextMeshProUGUI bestRecordText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinText;

    private float surviveTime;
    private float score;
    private bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime += Time.deltaTime;
            score = (PlayerController.CoinCount * 10) + surviveTime;
            timeText.text = $"Time: {Mathf.FloorToInt(surviveTime)}";
            coinText.text = $"coin: {PlayerController.CoinCount}";
            scoreText.text = $"Score: {Mathf.FloorToInt(score)}";
        }
        else
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOver.SetActive(true);

        float bsetScore = PlayerPrefs.GetFloat("BestTime", 0f);
        if (score > bsetScore)
        {
            bsetScore = (PlayerController.CoinCount * 10) + surviveTime;
            PlayerPrefs.SetFloat("BestTime", bsetScore);
            //PlayerPrefs.Save();
        }

        bestRecordText.text = $"Best Record: {Mathf.FloorToInt(bsetScore)}";
    }
}
