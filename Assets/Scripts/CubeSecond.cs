using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSecond : MonoBehaviour
{
    private float _moveSpeed = 1f;
    private Vector3 _viewTo = new Vector3(1, 0, 1);
    private float _rotateSpeed = 10f;
    private float _growSpeed = 0.001f;    

    private void Update()
    {
        transform.Translate(_viewTo * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_growSpeed, _growSpeed, _growSpeed);
    }
}
