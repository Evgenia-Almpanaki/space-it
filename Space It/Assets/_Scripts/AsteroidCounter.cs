using UnityEngine;
using UnityEngine.UI;

public class AsteroidCounter : MonoBehaviour
{
    public GameController gameController;

    private Text textField; 
    private int asteroidsLeft = 42;

    private void Start()
    {
        textField = GetComponent<Text>();
        UpdateUI();
    }

    public void DecreaseAsteroid() 
    {
        if (asteroidsLeft > 1)
        {
            asteroidsLeft--;
            UpdateUI();
        }
        else
            gameController.FinishGame(false);
    }

    private void UpdateUI() 
    {
        textField.text = "Asteroids Left: " + asteroidsLeft;
    }
}
