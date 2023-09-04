using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
   void Start()
    {
        //PlayerPrefs.DeleteAll();// kayıtlı levellerri siler
    }
    public void oyunaGit()
    { int kayitlilevel = PlayerPrefs.GetInt("Kayıt");
       if (kayitlilevel==0) 
        { 
        SceneManager.LoadScene(kayitlilevel+1);
        }
       else
        {
            SceneManager.LoadScene(kayitlilevel );
        }
    }
    public void cik()
    {
        Application.Quit();
      
    }






}
