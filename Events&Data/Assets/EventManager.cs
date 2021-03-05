using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent current;
    public Queue<UnityEvent> qgameEvenets;
    public int points;
    bool added = true;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (added)
        {
            AddListener();
        }
        RemoveListener();
    }
    void QueueEvent(UnityEvent events)
    {
        qgameEvenets.Enqueue(events);
    }
    void MyAction()
    {
        //Output message to the console
        TriggerEvent();
    }
    void AddListener()
    {
        MyAction();
    }
    void RemoveListener()
    {
        added = false;
    }

    void TriggerEvent()
    {
        void OnCollisionEnter(Collision collision)
        {




            if (collision.gameObject.CompareTag("Coin"))
            {
                points = points + 50;
                Destroy(collision.gameObject);
            }
        }

        
    }
}
