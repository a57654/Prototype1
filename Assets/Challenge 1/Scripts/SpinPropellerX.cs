using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000f;

    void Update()
    {
        // Gira a hélice ao redor do eixo Z
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
