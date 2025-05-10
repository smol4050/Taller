using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Scene2Controller : MonoBehaviour
{
    [Header("Temporizador")]
    [SerializeField] private float maxTime = 300f;
    private float remainingTime;
    private bool timerRunning = false;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;

    [Header("Spawn & Exit")]
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private Collider exitTrigger;

    private bool levelEnded = false;

    void Start()
    {
        remainingTime = maxTime;
        timerRunning = true;
        winPanel.SetActive(false);
        losePanel.SetActive(false);
        UpdateTimerUI();
    }

    void Update()
    {
        if (!timerRunning) return;

        remainingTime -= Time.deltaTime;
        UpdateTimerUI();

        if (remainingTime <= 0f)
        {
            remainingTime = 0f;
            timerRunning = false;
            OnTimeExpired();
        }
    }

    private void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60f);
        int seconds = Mathf.FloorToInt(remainingTime % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    private void OnTimeExpired()
    {
        if (levelEnded) return;
        levelEnded = true;
        losePanel.SetActive(true);
        
        Invoke(nameof(RestartScene), 3f);
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (levelEnded) return;
        // Condición de victoria
        if (other.CompareTag("Player") && other == exitTrigger)
        {
            levelEnded = true;
            timerRunning = false;
            winPanel.SetActive(true);
            
        }
    }

    public void PenalizeDeath(float penaltySeconds = 30f)
    {
        if (levelEnded) return;
        remainingTime -= penaltySeconds;
        if (remainingTime < 0f) remainingTime = 0f;
        UpdateTimerUI();
    }
}
