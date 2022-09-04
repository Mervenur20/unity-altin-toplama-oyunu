using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            
           SceneManager.LoadScene("S4Level2");

        }

       if (collision.gameObject.tag == "Cube1")
        {
            
            SceneManager.LoadScene("S5Level3");

        }

       
        if (collision.gameObject.tag == "Cube2")
        {
            
            SceneManager.LoadScene("S6KazanmaSahnesi");

        }

       
       
    }


}
