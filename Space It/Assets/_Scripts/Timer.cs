using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameController gameController;

    private Text textfield;
    private float secondsLeft = 120f;

    private void Awake()
    {
        textfield = GetComponent<Text>();
    }

    private void Update()
    {
        if (secondsLeft < 0)
            gameController.FinishGame(false);

        secondsLeft -= Time.deltaTime;
        UpdateUI();
    }

    private void UpdateUI()
    {
        textfield.text = "Time Left: " + Mathf.Clamp(secondsLeft, 0, Mathf.Infinity).ToString("F2");
    }
}
