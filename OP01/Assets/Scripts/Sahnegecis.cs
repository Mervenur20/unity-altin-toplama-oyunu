using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahnegecis : MonoBehaviour
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
    if (collision.gameObject.tag == "cub")
        {
            
        int sahne_id = 3;
        SceneManager.LoadScene(sahne_id + 1);

        }
    }
}
