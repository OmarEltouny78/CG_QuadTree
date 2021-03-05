using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(points);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1);
        if (other.gameObject.CompareTag("Coin"))
        {
            points = points + 50;
            Destroy(other.gameObject);
        }
    }
}
