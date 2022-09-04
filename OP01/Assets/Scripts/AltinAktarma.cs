using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltinAktarma : MonoBehaviour
{
    public static int toplam_altin;
    public Text altin_text;
    // Start is called before the first frame update
   void Start()
    {
        toplam_altin = PlayerPrefs.GetInt("miktar");
        altin_text.text = toplam_altin + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
