using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaÇember : MonoBehaviour
{
    public GameObject kucukCember;
    GameObject OyunYoneticisi;
    // Start is called before the first frame update
    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYöneticisiTag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukcemberolustur();

        }
        
    }
    void kucukcemberolustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        OyunYoneticisi.GetComponent<OyunYöneticisi>().kucukCemberlerdeTextGosterme();
    }
}
