using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSecond : MonoBehaviour
{
    private float _moveSpeed = 1f;
    private float _rotateSpeed = 10f;
    private float _growSpeed = 0.0001f;    

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_growSpeed, _growSpeed, _growSpeed);
    }
}
