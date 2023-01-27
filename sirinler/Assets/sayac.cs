using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayac : MonoBehaviour
{
    int yerlestirilen_sirin = 0;
    int toplam_golge = 5;
    public GameObject win;
    
    
    public void sayi_arttir()
    {
        yerlestirilen_sirin++;
        Debug.Log(yerlestirilen_sirin);

        if (yerlestirilen_sirin==toplam_golge)
        {
            win.SetActive(true);
            Debug.Log("bitis");
        }
    }

   
}
