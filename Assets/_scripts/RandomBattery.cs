using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBattery : MonoBehaviour {

    // battery objects
    public GameObject bat_AA, bat_C, bat_9V;

    // instantiator
    public GameObject instantiator;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            int random_bat = Random.Range(0, 3);
            float random_x_rot = Random.Range(-90, 90);
            Vector3 pos = new Vector3(-0.2f, 3, 0);
            Quaternion rotation = Quaternion.Euler(Random.Range(-90, 90), 0, 0);
            
            switch (random_bat)
            {
                case 0:
                    Instantiate(bat_AA, pos, rotation);
                    break;
                case 1:
                    Instantiate(bat_C, pos, rotation);
                    break;
                case 2:
                    Instantiate(bat_9V, pos, rotation);
                    break;
                default:
                    break;
            }
        }
	}
    
}
