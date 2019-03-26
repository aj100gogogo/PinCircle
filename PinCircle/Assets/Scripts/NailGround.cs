using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailGround : MonoBehaviour
{
    public float speed = 0.1f;
    public bool isFired = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFired = true;
        }
        if (isFired == true)
        {
            this.transform.Translate(0, speed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isFired = false;
        this.transform.SetParent(collision.transform);
    }
}