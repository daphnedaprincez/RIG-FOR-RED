using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Creates a sonar pulse animation effect on the UI
/// </summary>
public class SonarEffect : MonoBehaviour
{
    [Header("Sonar Animation Settings")]
    [SerializeField] private float pulseSpeed = 2f;
    [SerializeField] private float minAlpha = 0.3f;
    [SerializeField] private float maxAlpha = 1f;

    private Image image;
    private float time;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (image == null) return;

        // Create pulsing effect using sine wave
        time += Time.deltaTime * pulseSpeed;
        float alpha = Mathf.Lerp(minAlpha, maxAlpha, (Mathf.Sin(time) + 1f) / 2f);

        Color color = image.color;
        color.a = alpha;
        image.color = color;
    }
}
