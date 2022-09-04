using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kaybolma : MonoBehaviour
{
    public GameObject kaydirma = null; //Unityde görünmesi için bir gameobject değişkeni tanımladık
   
    
     void Start()
    {
        kaydirma.SetActive(false); //SetActive fonksiyonu objenin görünürlüğünü kapatır. Tam tersini yapmak için yani objenin görünürlüğünü açmak için false yerine true yazılır.

        StartCoroutine(WaitBeforeShow());// Fonksiyon çağrılır.

    }

    void Update()
    {
       
    }
    private IEnumerator WaitBeforeShow() 
    {
        for (int i = 0; i < 444; i++)
        {

            if (i % 2 == 0)//Eğer i den kalan çiftese yandır tekse söndür.
            {
                yield return new WaitForSeconds(1);//1 s  aktifleştir
                kaydirma.SetActive(true);
            }
            else//tekse kalan 0 eşit değilse söndür
            {
                yield return new WaitForSeconds(1);
                kaydirma.SetActive(false); //Söndürme işlemi
            }
        }
    }

}
