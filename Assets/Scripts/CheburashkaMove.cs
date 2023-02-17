using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheburashkaMove : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject  _chebu;
    [SerializeField] private GameObject _upBasketChebu;
    [SerializeField] private float _movementSpeed;
    private bool isLeft;
    private bool isUp;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(isUp)
            {
                Destroy(_upBasketChebu);
                Instantiate(_chebu, _container);
                isLeft = true;
            }
            if (!isLeft)
            {
                transform.localScale = new Vector3(1, 1, 1);
                isLeft = true;
            }
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            var target = transform.position;
            target.x += horizontalInput;
            transform.position = Vector3.MoveTowards(transform.position, target, _movementSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (isUp)
            {
                Destroy(_upBasketChebu);
                Instantiate(_chebu, _container);
                transform.localScale = new Vector3(-1, 1, 1);
                isLeft = false;
            }
            if (isLeft)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                isLeft = false;
            }
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            var target = transform.position;
            target.x += horizontalInput;
            transform.position = Vector3.MoveTowards(transform.position, target, _movementSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale = new Vector3(1, 1, 1);
            if (!isUp)
            {
                Destroy(_chebu);
                Instantiate(_upBasketChebu, _container);
                isUp = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale = new Vector3(- 1, 1, 1);
            if (!isUp)
            {
                Destroy(_chebu);
                Instantiate(_upBasketChebu, _container);
                isUp = true;
            }
        }
    }
}
