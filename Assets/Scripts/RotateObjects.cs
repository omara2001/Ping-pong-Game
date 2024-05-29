using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    public int rotateSpeed = 2;
    //not all objects could rely on the time scale
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.timeScale, Space.World);
    }
}
