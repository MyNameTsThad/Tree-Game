using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;

    public float xOffset = 1f;
    public float yOffset = 1f;

    


    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x + xOffset;
        temp.y = playerTransform.position.y + yOffset;
        transform.position = temp;

    }

    private void OnDrawGizmos()
    {
        Vector3 pos = new Vector3(playerTransform.position.x + xOffset, playerTransform.position.y + yOffset);

        Gizmos.DrawWireSphere(pos, 1f);
    }
}
