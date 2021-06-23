using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractor_Move : MonoBehaviour
{
    public float tractor_speed;
    // Start is called before the first frame update
    void Start()
    {
        SFX.Play_Trac();
        Destroy(gameObject, 30.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, tractor_speed * Time.deltaTime);
    }
}
