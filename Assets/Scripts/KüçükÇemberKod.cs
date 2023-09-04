using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KüçükÇemberKod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject oyunYöneticisi;
    void Start()
    {  //bir scriptten ötekine ulaşmak
        fizik = GetComponent<Rigidbody2D>();
        oyunYöneticisi = GameObject.FindGameObjectWithTag("OyunYöneticisiTag");
    }


    void FixedUpdate()//örneğin 1.snde 1 kez çalısır.2O.snde 2 kez vb.
    {
        if (hareketKontrol == false)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "DönenÇemberTag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
        }
        if (col.tag == "KüçükÇemberTag")
        {
            oyunYöneticisi.GetComponent<OyunYöneticisi>().OyunBitti();
            //önce oyun yöneticisini bulduk.şimdi bulup oyun bitti metodu ile eşleştirdik
        }
    }
}
