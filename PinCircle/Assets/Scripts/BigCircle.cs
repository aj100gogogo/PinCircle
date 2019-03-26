using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCircle : MonoBehaviour
{
    public float rotateSpeed = 1f;

    private void Update()
    {
        this.transform.Rotate(0, 0, rotateSpeed);
    }
}