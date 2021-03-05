using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInteract : MonoBehaviour
{
    float height = 0.5f;
    float speed = 5f;
    Vector3 pos;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 90 * Time.deltaTime, 0,0);
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        if (timerIsRunning)
        {
            if (timeRemaining > 0) {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
                timeRemaining = 0;
                timerIsRunning = false;
            }
           
        }
       

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1);
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerScore>().points++;
            Destroy(gameObject);
        }
    }
}
