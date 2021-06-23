using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    public string Finish_Scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            End_Game();
        }
    }

    void End_Game()
    {
        SceneManager.LoadScene(Finish_Scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
