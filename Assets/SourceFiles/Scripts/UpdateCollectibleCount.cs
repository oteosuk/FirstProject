using UnityEngine;
using TMPro;

public class UpdateCollectibleCount : MonoBehaviour
{
    private TextMeshProUGUI collectibleText;

    void Start()
    {
        collectibleText = GetComponent<TextMeshProUGUI>();
        if (collectibleText == null)
        {
            Debug.LogError("UpdateCollectibleCount script requires a TextMeshProUGUI component on the same GameObject.");
            return;
        }
        UpdateCollectibleDisplay();
    }

    void Update()
    {
        UpdateCollectibleDisplay();
    }

    private void UpdateCollectibleDisplay()
    {
        int totalCollectibles = FindObjectsByType<Pickup>(FindObjectsSortMode.None).Length;
        collectibleText.text = $"Collectibles remaining: {totalCollectibles}";
    }
}
