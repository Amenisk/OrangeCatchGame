using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCreator : MonoBehaviour
{
    [SerializeField] Rigidbody2D _orangePrefab;
    float time = 5;

    void Start()
    {
        StartCoroutine(SpawnOrange());
    }

    private IEnumerator SpawnOrange()
    {
        while(true)
        {
            if (Game.Points > 10)
            {
                time = 4;
            }
            else if (Game.Points > 20)
            {
                time = 3;
            }
            else if (Game.Points > 30)
            {
                time = 2;
            }
            else if (Game.Points > 40)
            {
                time = 1;
            }

            Instantiate(_orangePrefab, gameObject.transform.GetChild(Random.Range(0, 4)));
            yield return new WaitForSeconds(time);
        }
    }
}
