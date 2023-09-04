using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunYöneticisi : MonoBehaviour
{

    GameObject dönenÇember;
    GameObject AnaÇember;
    public Animator animator;
    public Text DonenCemberLevel;
    public Text bir, iki, uc;
    public int kacTaneKucukCemberOlsun;
    bool kontrol = true;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Kayıt",int.Parse(SceneManager.GetActiveScene().name));
        dönenÇember = GameObject.FindGameObjectWithTag("DönenÇemberTag");
        AnaÇember = GameObject.FindGameObjectWithTag("AnaÇemberTag");

        DonenCemberLevel.text = SceneManager.GetActiveScene().name;
        if (kacTaneKucukCemberOlsun < 2)
        {
            bir.text = kacTaneKucukCemberOlsun + "";


        }
        else if (kacTaneKucukCemberOlsun < 3)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";

        }
        else
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = (kacTaneKucukCemberOlsun - 2) + "";
        }
    }
    public void kucukCemberlerdeTextGosterme()
    {
        kacTaneKucukCemberOlsun--;
        if (kacTaneKucukCemberOlsun < 2)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = "";
            uc.text = "";

        }
        else if (kacTaneKucukCemberOlsun < 3)
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = "";

        }
        else
        {
            bir.text = kacTaneKucukCemberOlsun + "";
            iki.text = (kacTaneKucukCemberOlsun - 1) + "";
            uc.text = (kacTaneKucukCemberOlsun - 2) + "";
        }
        if (kacTaneKucukCemberOlsun == 0)
        {
            StartCoroutine(yeniLevel());
        }
    }
    IEnumerator yeniLevel()
    {
        dönenÇember.GetComponent<Döndürme>().enabled = false;
        AnaÇember.GetComponent<AnaÇember>().enabled = false;
        yield return new WaitForSeconds(1);
        if (kontrol==true)
        {
            
            animator.SetTrigger("Yenilevel");
            yield return new WaitForSeconds(1f);

         SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) +1);
         

        }
       

     
    }

    public void OyunBitti()
    {
        StartCoroutine(CagrilanMetot());
    }
    IEnumerator CagrilanMetot()
    {
        dönenÇember.GetComponent<Döndürme>().enabled = false;
        AnaÇember.GetComponent<AnaÇember>().enabled = false;
        animator.SetTrigger("oyunbitti"); kontrol = false;
        yield return new WaitForSeconds(2F);
       
       

        SceneManager.LoadScene("anamenu");

    }
}
