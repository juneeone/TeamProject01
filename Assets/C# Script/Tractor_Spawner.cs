using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractor_Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public float interval;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(true)
        {
            Instantiate(Prefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
