using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class ExclusionZone : MonoBehaviour
{
    [SerializeField] private GameObject _getDamageBackground;
    public async void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        _getDamageBackground.SetActive(true);

        await Task.Delay(300);

        _getDamageBackground.SetActive(false);
        Game.HealthPoints--;
    }
}
