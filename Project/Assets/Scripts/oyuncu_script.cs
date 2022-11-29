using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyuncu_script : MonoBehaviour
{
    Rigidbody yercekimi;
    
    public float hiz = 6.0f;

    int sayac = 0;
    public Text kutuSayisiGoster;
    void Start()
    {
        yercekimi = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float yatay_hareket = Input.GetAxis("Horizontal");
        float dikey_hareket = Input.GetAxis("Vertical");

        Vector3 vc = new Vector3(yatay_hareket,0,dikey_hareket);

        yercekimi.AddForce(vc*hiz);
        
        
    }
    void OnCollisionEnter(Collision carpılan)
     
    {
        if (carpılan.gameObject.name == "Kutucuk(Clone)")
        {
            Destroy(carpılan.gameObject);
            sayac++;
            kutuSayisiGoster.text = "Toplanan Kutu = " + sayac;
            //Debug.Log(sayac + " kutu toplandı");
        }
        else if(carpılan.gameObject.name == "yasakliKutucuk(Clone)"){
            Destroy(carpılan.gameObject);
            sayac--;
            kutuSayisiGoster.text = "Toplanan Kutu = " + sayac;
            // Debug.Log(sayac + " yasakli kutu toplandı");

            //puan 0'ın altına düşerse eğer oyun yeniden başlar.
            if(sayac < 0){
                MenuControl obj = new MenuControl();
                obj.yenidenBaslat();
            }
        }
    }
}
