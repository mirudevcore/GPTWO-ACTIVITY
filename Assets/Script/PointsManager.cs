using UnityEngine;
using TMPro;

public class PointsManager : MonoBehaviour
{
    
    public static PointsManager Instance { get; private set; }

    public TMP_Text pointsText;
    private int points = 0;

    private void Awake()
    {
        
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        pointsText.text = "Points: " + points;
    }

    public void IncreasePoints(int amount)
    {
        points += amount;
        pointsText.text = "Points: " + points;
    }
}
