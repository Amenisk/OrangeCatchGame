using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheburashkaMove : MonoBehaviour
{
    [SerializeField] private GameObject _basket;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
            transform.localPosition = new Vector3(-0.59f, -1.42f, 0);
            _basket.transform.localPosition = new Vector3(-7.62f, -2.57f, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);
            transform.localPosition = new Vector3(0.39f, -1.42f, 0);
            _basket.transform.localPosition = new Vector3(-7.62f, -2.57f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
            transform.localPosition = new Vector3(-0.59f, -1.42f, 0);
            _basket.transform.localPosition = new Vector3(-5.72f, 1.15f, 0);

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);
            transform.localPosition = new Vector3(0.39f, -1.42f, 0);
            _basket.transform.localPosition = new Vector3(-5.72f, 1.15f, 0);
        }
    }
}