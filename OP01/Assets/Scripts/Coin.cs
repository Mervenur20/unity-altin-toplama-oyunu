using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin: MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//tag ı player olan nesne Trigger alanına değdiği an çalışmaktadır.
        {
            CoinText.coinAmount += 5;//cointext topladığım altınları 5 arttırıyor 
            Destroy(gameObject);
            PlayerPrefs.SetInt("miktar", CoinText.coinAmount);//Cointext.coinamunt altın sayılarını kaydetmek için kullanılır.Cointext.coinamunt miktarın içine yazıyoruz
            Destroy(gameObject);
        }

    }
}
