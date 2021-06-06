using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//각종 효과음을 관리하는 곳. SoundManager에 부착
//배경음악은 MainCamera
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
    
    //보석 획득 효과음
    public static void Play_Jem()
    {
        audiosource.PlayOneShot(JemCapture);
    }

    //열쇠 효과음
    public static void Play_Key()
    {
        audiosource.PlayOneShot(Key);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
