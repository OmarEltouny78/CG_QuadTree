using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject apple;
    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        int random= Random.Range(0, 10);
        apple.transform.position = new Vector3(random, y, 0);
    }


}
