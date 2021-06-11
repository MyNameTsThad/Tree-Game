using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepRot : MonoBehaviour
{
    public float yRot = -180f;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0f, yRot, 0f);
    }
}
