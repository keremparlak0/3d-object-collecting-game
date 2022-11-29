using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public static bool oyunDurduMu = false;
    public GameObject pauseMenuUI;
    public GameObject oyuncu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(oyunDurduMu){
                devamEt();
            }else{
                durdur();
            }
        }
        //Eğer oyuncu platformdan düşerse oyun yenilenecek.
        if(oyuncu.transform.position.y<-15){
            yenidenBaslat();
        }
    }

    //Devam Et tuşuna basıldığında çağırılacak fonksiyon
    public void devamEt(){
        Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        oyunDurduMu = false;
    }

    void durdur(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        oyunDurduMu = true;
    }
    
    
    //Yeniden Başlat tuşuna basıldığında çağırılacak fonksiyon
    public void yenidenBaslat(){
        Debug.Log("Restart");
        SceneManager.LoadScene("SampleScene");
        //Restart Yaptığımızda top havada kalıyor ve escape tusuna basmamız gerekiyordu
        //Bu sorun yaşanmasın diye devamEt() fonksiyonunu çağırdık
        devamEt();
    }
    
}
