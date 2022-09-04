using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Sahne değişimi için kütüphanemizi ekledik.

public class ButtonKodlari : MonoBehaviour
{
    public void sahneyiAc(string sceneName) //Bir method oluşturdum bu methodum parametre olarak bir string alıcak. Public dedim çünkü bu methodumu unityde kullanıcam.
    {
        SceneManager.LoadScene(sceneName); //Burda sana ismini girdim sahneyi yükle diyorum.
    }

    public void OyunCikis() //Fonksiyonumu oluşturdum.
    {
        Debug.Log("Oyundan Çıktık!"); //Console ekranında görünsün diye yazdım
        Application.Quit();// Bu kısım olmazsa editörde çalışmaz.
    }

 
}
