using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerClamp : MonoBehaviour
{
    [SerializeField]
    public Transform target;
    //public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(target.position.y, 0, 99999999f),
            transform.position.z
        );
    }
}
