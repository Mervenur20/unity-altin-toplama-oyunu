using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    Text text;
    public static int coinAmount;//static” değişkenlere global değişkenler diyebiliriz. “static” bir değişkeni tüm üyeler kullanabilir. Yani değeri her yerde aynıdır.


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();//Text değişiklik yapmak için GetComponet kullanılır.
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString(); //String e cevirip text e yazıyoruz
    }
}
