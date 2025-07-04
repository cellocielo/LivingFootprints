using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class TextFadeParticleSystem : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] messages;
    public float fadeDuration = 1f;
    public float displayTime = 2f;

    public ParticleSystem particles;
    public int activateParticlesOnLine = 1;

    private void Start()
    {
        if (particles != null)
        {
            particles.Stop();

        StartCoroutine(CycleText());
        }
    }

    IEnumerator CycleText() {
        for (int index = 0; index < messages.Length; index++)
        {
            textComponent.text = messages[index];

            yield return StartCoroutine(FadeTextAlpha(0, 1));

            if (index == activateParticlesOnLine && particles != null)
            {
                particles.Play();
            }

            yield return new WaitForSeconds(displayTime);

            yield return StartCoroutine(FadeTextAlpha(1, 0));
        }

        textComponent.text = "";

        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator FadeTextAlpha(float from, float to) {
        float elapsed = 0f;
        Color c = textComponent.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(from, to, elapsed / fadeDuration);
            textComponent.color = new Color(c.r, c.g, c.b, alpha);
            yield return null;
        }

        textComponent.color = new Color(c.r, c.g, c.b, to);
    }
}
