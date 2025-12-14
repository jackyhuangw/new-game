using UnityEngine;
using TMPro;
using System.Net.NetworkInformation;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI killCountText;

    private int killCount;

    void Awake()
    {
        instance = this;
        Time.timeScale = 1f;
    }

    void Update()
    {
        timerText.text = Time.timeSinceLevelLoad.ToString("F2") + "s";
    }

    public void EnableGameOverUI()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void AddKillCount()
    {
        killCount++;
        killCountText.text = killCount.ToString();
    }

    public void RestartLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
