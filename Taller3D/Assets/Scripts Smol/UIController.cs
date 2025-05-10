using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
    public TextMeshProUGUI countText;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void UpdateCount(int count)
    {
        countText.text = $"Mecanismos: {count}";
    }
}
