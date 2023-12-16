using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int ilksayi;
    int sonsayi;
    string hepsi;
    string ikiye;
    string üçe;

    void bölenleribul(int ilksayi, int sonsayi)
    {
        for (int i = ilksayi; i <= sonsayi; i++)
        {
            
            hepsi += i.ToString();
            if (i < sonsayi) // Add a comma if it's not the last number
            {
                hepsi += ",";
                
            }
            if(i%2==0)
            {
                ikiye += i.ToString();
                if (i < sonsayi) // Add a comma if it's not the last number
                {
                    ikiye += ",";

                
                }
                
            }
            if(i%3==0)
            {
                
                üçe += i.ToString();
                if (i < sonsayi) // Add a comma if it's not the last number
                {
                    üçe += ",";

                
                }
                
            }
            
    
        }
        print("Hepsi: " + hepsi);
        print("İkiye Bölünenler: " + ikiye);
        print("Üçe Bölünenler: " + üçe);
        
 
     }

    // Start is called before the first frame update
    void Start()
    { 
        ilksayi = 1;
        sonsayi = 10;
        bölenleribul(ilksayi, sonsayi);
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
