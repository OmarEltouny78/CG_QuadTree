using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public GameObject theCoin;
    public int xPos;
    public int zPos;
    public int coinsNumber;
    public int maxN;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinDrop());
    }
    IEnumerator CoinDrop()
    {
        while (coinsNumber < maxN)
        {
            xPos = Random.Range(1, 11);
            zPos = Random.Range(1, 11);
            Instantiate(theCoin, new Vector3(xPos, -4, zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            coinsNumber += 1;
        }
    }

 
}
