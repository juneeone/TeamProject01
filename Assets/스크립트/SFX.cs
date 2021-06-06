using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    static AudioSource audiosource;
    public static AudioClip JemCapture;
    public static AudioClip Key;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        JemCapture = Resources.Load<AudioClip>("JEM");
        Key = Resources.Load<AudioClip>("KEY");
    }
    
    public static void Play_Jem()
    {
        audiosource.PlayOneShot(JemCapture);
    }

    public static void Play_Key()
    {
        audiosource.PlayOneShot(Key);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
