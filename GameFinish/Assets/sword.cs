
using UnityEngine;

public class sword : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject gameobject;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(gameobject.transform.position, gameobject.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
