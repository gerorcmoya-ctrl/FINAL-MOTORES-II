using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private int totalCoinsInLevel;

    private int coinsCollected = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddCoin()
    {
        coinsCollected++;
        UpdateUI();
    }

    public bool AllCoinsCollected()
    {
        return coinsCollected >= totalCoinsInLevel;
    }

    private void UpdateUI()
    {
        coinText.text = $"{coinsCollected} / {totalCoinsInLevel}";
    }
}