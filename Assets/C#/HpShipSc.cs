using System.Collections;
using UnityEngine;

public class HpShipSc : MonoBehaviour
{
    public float Hp = 100f;
    public bool CanHeal = false;
    //public bool 
    void Start()
    {
        
    }


    void Update()
    {
        if (Hp >= 100)
        {
            CanHeal = false;
        }
        else 
        {
            CanHeal = true;
        }
        if (Hp < 100 && CanHeal == true)
        {
            CanHeal = false;
            WaitForSeconds wait = new WaitForSeconds(1);
            Hp = Hp + 0.1f;
            CanHeal = true;
        }
        if (Hp <= 0) 
        {
        
        }
    }
	void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.CompareTag("Meteorite")) 
        {
            Hp=Hp-50;
            CanHeal = false;
            WaitForSeconds wait2 = new WaitForSeconds(10);
            CanHeal = true;
        }	
	}
}
