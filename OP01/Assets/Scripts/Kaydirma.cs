using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Kodda UI elemenanlarını kullanmak için yazılan kütüphanedir.

public class Kaydirma : MonoBehaviour
{

    public Vector3 sess; //public içinde sess olarak vektor değişkenimi tanımladım.
    public Text text;
    public float pozisyon;
    public bool yukarı = false; // mantıksal değişkenler
    public bool aşağı = false;


    void LateUpdate()
    {

    }

    
    void Update() //Kontrollerimizi yazmaya başlıyoruz.
    {

        if (yukarı == true && pozisyon <= 290) //bool tipinde yukarı değişkenini true olarak aktif olduğunda ve pozisyonum 290 dedim çünkü sahnemin boyutu yani yazımın 290 kadar çıkıp ordan tekrar inmesini istediğim için
        {  
            pozisyon++;
            sess.y = pozisyon; //vector3 tanımladığım değişkinemi alıyorum pozisyona atıyorum.
            text.GetComponent<Text>().fontSize = 22; //Text mizin fontsize arttrıyor.
            if (pozisyon == 290) //pozisyon 290 olduğu zaman290 kadar çıkıp geri dönsün diye
            {
                pozisyon++;
                aşağı = true;//aşağı doğru inmsesi için
                yukarı = false;
                sess.y = pozisyon; //poziyonumu alıp pozisyona atıyorum. y pozisyonu yukarı aşağı hareket için
            }
        }

        if (aşağı == true)
        {
            pozisyon--; //Aşağı doğru insin diye
            sess.y = pozisyon;
            text.GetComponent<Text>().fontSize = 15; //Text mizin fontsize azaltıyor.
            if (pozisyon == 0) //pozisyon 0 olduğunda yani aşağıdan yukarı çıktığı zaman
            {
                pozisyon--;
                aşağı = false;
                yukarı = true;
                sess.y = pozisyon;
            }

        }
        text.rectTransform.position = sess; //Pozisyonumu alıp sess atıyorum eiştlensinki hareket etsin.

    }


}
