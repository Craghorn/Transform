using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
