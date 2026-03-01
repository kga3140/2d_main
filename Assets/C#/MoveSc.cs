using UnityEngine;

public class MoveSc : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Spd = 10f;
    public float TurnSpd = 10f;




    void Update()
    {
		if (Input.GetKey(KeyCode.W))
		{
			MoveF();
		}
		if (Input.GetKey(KeyCode.S))
		{
			MoveB();
		}
		if (Input.GetKey(KeyCode.A))
		{
			Turn(TurnSpd);
		}
		if (Input.GetKey(KeyCode.D))
		{
			Turn(TurnSpd*-1);
		}
	}

    void MoveF()
	{
		rb.AddForce(transform.right * Spd, ForceMode2D.Impulse);

	}
	void MoveB()
	{
		rb.AddForce(transform.right * Spd*-1, ForceMode2D.Impulse);
	}
	void Turn(float turn) 
    {
        rb.AddTorque(turn, ForceMode2D.Impulse);
    }
}
