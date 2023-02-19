using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class Busket : MonoBehaviour
{
    [SerializeField] private GameObject TextField;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Game.Points++;
        TextField.GetComponent<TextMeshProUGUI>().text = Game.Points.ToString();
    }
}
