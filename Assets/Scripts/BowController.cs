using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    private Vector2 _direction;
   
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 bowPosition = transform.position;

        _direction = mousePos - bowPosition;
        transform.right = _direction;
    }
}
