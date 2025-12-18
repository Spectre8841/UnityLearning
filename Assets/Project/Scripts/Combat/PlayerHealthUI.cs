using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [Header("References")]
    public Health playerHealth;
    public Image fillImage;

    private void Start()
    {
        UpdateHP();
    }

    private void Update()
    {
        UpdateHP();
    }

    private void UpdateHP()
    {
        if (playerHealth == null || fillImage == null) return;

        fillImage.fillAmount =
            (float)playerHealth.currentHealth / playerHealth.maxHealth;
    }
}
