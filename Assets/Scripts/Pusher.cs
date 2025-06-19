using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public GameObject pusher = default;
    public Vector3 defaultposition;
    public float pushpower = 0f;

    // Start is called before the first frame update
    void Start()
    {
        defaultposition = pusher.transform.localPosition;
    }

    void Update()
    {
        float z = pushpower * Mathf.Sin(Time.time);
        Debug.Log(z);
        pusher.transform.localPosition = new Vector3(0, 0, z) + defaultposition;
    }
}
