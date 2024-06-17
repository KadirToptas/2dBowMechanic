using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    private Vector2 _direction;
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private float speed;
   
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 bowPosition = transform.position;

        _direction = mousePos - bowPosition;
        transform.right = _direction;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject newArrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
        newArrow.GetComponent<Rigidbody2D>().AddForce(transform.right*speed);
    }
}
