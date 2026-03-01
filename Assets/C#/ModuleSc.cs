using UnityEngine;

public class ModuleSc : MonoBehaviour
{
    public int Module1 = 0;
    public int Module2 = 0;

    public GameObject MinerV1Mod1;
    public GameObject LaserV1Mod1;
	public GameObject ShieldV1Mod1;


	public GameObject MinerV1Mod2;
	public GameObject LaserV1Mod2;
	public GameObject ShieldV1Mod2;


	void Start()
    {
    
    }


    void Update()
    {
        if (Module1 == 0) 
        {
            MinerV1Mod1.SetActive(false);
            LaserV1Mod1.SetActive(false);
            ShieldV1Mod1.SetActive(false);
        }
        else if (Module1 == 1)
		{
			MinerV1Mod1.SetActive(true);
			LaserV1Mod1.SetActive(false);
            ShieldV1Mod1.SetActive(false);
		}
		else if (Module1 == 2)
		{
			MinerV1Mod1.SetActive(false);
			LaserV1Mod1.SetActive(true);
			ShieldV1Mod1.SetActive(false);
		}
        else if (Module1 == 3)
		{
			MinerV1Mod1.SetActive(false);
			LaserV1Mod1.SetActive(false);
			ShieldV1Mod1.SetActive(true);
		}

		if (Module2 == 0)
		{
			MinerV1Mod2.SetActive(false);
			LaserV1Mod2.SetActive(false);
			ShieldV1Mod2.SetActive(false);
		}
		else if (Module2 == 1)
		{
			MinerV1Mod2.SetActive(true);
			LaserV1Mod2.SetActive(false);
			ShieldV1Mod2.SetActive(false);
		}
		else if (Module2 == 2)
		{
			MinerV1Mod2.SetActive(false);
			LaserV1Mod2.SetActive(true);
			ShieldV1Mod2.SetActive(false);
		}
		else if (Module2 == 3)
		{
			MinerV1Mod2.SetActive(false);
			LaserV1Mod2.SetActive(false);
			ShieldV1Mod2.SetActive(true);
		}

	}
}
