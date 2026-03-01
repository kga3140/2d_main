using UnityEngine;

public class HpSc : MonoBehaviour
{
	public float Hp = 100f;
	public bool CanHeal = false;
	public float dmgForMeteorite=50;
	//public bool 
	void Start()
	{

	}


	void Update()
	{

	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("Meteorite"))
		{
			Hp = Hp - dmgForMeteorite;
			CanHeal = false;
			WaitForSeconds wait2 = new WaitForSeconds(10);
			CanHeal = true;
		}
	}
}
