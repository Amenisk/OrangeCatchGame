using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCreator : MonoBehaviour
{
    [SerializeField] Rigidbody2D _orangePrefab;
    float time = 5;
    
    private void Update()
    {
        time = time - Time.deltaTime;
        if (time < 0)
        {
            Instantiate(_orangePrefab, gameObject.transform.GetChild(Random.Range(0, 4)));
            time = 5;
        }
    }
}
