using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _healths;
    [SerializeField] private GameObject TextField;
    public static int HealthPoints { get; set; }
    public static int Points { get; set; }
    private int oldPoints;

    void Start()
    {
        HealthPoints = 3;
        oldPoints = HealthPoints;
        foreach(var h in _healths.GetComponentsInChildren<SpriteRenderer>())
        {
            h.color = Color.red;
        }
    }

    private void Update()
    {
        if(HealthPoints == 0)
        {
            Time.timeScale = 0.0f;
            _canvas.SetActive(true);
        }

        if(oldPoints != HealthPoints)
        {
            foreach(var h in _healths.GetComponentsInChildren<SpriteRenderer>())
            {
                if(h.color != Color.black)
                {
                    h.color = Color.black;
                    break;
                }             
            }
            oldPoints--;
        }
    }

    public void RebootGame()
    {
        Points = 0;
        TextField.GetComponent<TextMeshProUGUI>().text = Game.Points.ToString();
        Time.timeScale = 1.0f;
        _canvas.SetActive(false);
        Start();
    }
}
