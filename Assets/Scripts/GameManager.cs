using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI message;
    private bool gameOver = false;

    void Start()
    {
        Time.timeScale = 1f;
        if (message != null)
            message.text = "Reach the Goal. Avoid the Hazard. Press R to restart.";
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Win()
    {
        gameOver = true;
        if (message != null)
            message.text = "You WIN! Press R to restart.";
        Time.timeScale = 0f;
    }

    public void Lose()
    {
        gameOver = true;
        if (message != null)
            message.text = "You LOSE! Press R to restart.";
        Time.timeScale = 0f;
    }
}
