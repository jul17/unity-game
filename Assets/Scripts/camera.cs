using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform tankTransform;

    private Vector3 cameraOffset;

    public float SmoothFactor = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - tankTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = tankTransform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
