using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class yonetici : MonoBehaviour
{
    int yerlestirilen_parca = 0;
    int toplam_puzzle = 16;
   public string sahne;
    public float sayac;
    public Text sayacText;
    void Start()
    {
        //  sahne=int.Parse( SceneManager.GetActiveScene().name);
        // Debug.Log(sahne);
        sayacText.text = "Sure: " + sayac.ToString();
    }

    public void sayi_artir()
    {
        yerlestirilen_parca++;
        if (yerlestirilen_parca == toplam_puzzle)
        {
            SceneManager.LoadScene(sahne);
        }
    }
    void Update()
    {
        sayac = sayac - Time.deltaTime;
        sayacText.text = "Sure: "+sayac.ToString(); 
        if (yerlestirilen_parca > 15)
        {
            sayi_artir();
        }
        if (sayac <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    public void BaslaButon()
    {
        SceneManager.LoadScene("1");
    }
    public void CikisButon()
    {
        Application.Quit();
    }
}
