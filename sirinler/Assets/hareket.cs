using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangic_pozisyon;
    private GameObject finishScreen;
    sayac say;
    
    // Start is called before the first frame update
    void Start()
    {
        
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangic_pozisyon = transform.position;
        
        
    }


    private void OnMouseDrag()
    {

        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
   

    void Update()
    {
        
        
            
            if (Input.GetMouseButtonUp(0))
            {
                foreach (GameObject golge in golgeler)
                {
                    if (gameObject.name == golge.name)
                    {
                        float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                        if (mesafe <= 1)
                        {
                            transform.position = golge.transform.position;
                            transform.parent.gameObject.GetComponent<sayac>().sayi_arttir();
                            Destroy(this);
                            



                        }
                        else
                        {
                            transform.position = baslangic_pozisyon;
                        }
                    }
                }


            }

        
        
    }
    
}
