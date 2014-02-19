using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	
	// references to our blueprints / PREFABS... assign in inspector
	public Transform bambooPrefab1, treePrefab1, treePrefab2, treePrefab3, treePrefab4, treePrefab5;
	public float xMin=0, xMax=0, zMin=0, zMax=0;
	
	public int plantCount = 0;
	int counter = 0;
	
	// Update is called once per frame
	void Update () {
		
		// only do this if we have less than 500 buildings already
		// (if we dont set a limit, then it will spawn FOREVER and might make Unity crash!)
		if (counter < plantCount )
		{
			// the core of this logic is the same as TenPrint.cs: "randomly do either X or Y"
			float randomNumber = Random.Range (0f, 100f);

			if (randomNumber<25){
				// Spawn a bamboo plant
				Instantiate (bambooPrefab1, new Vector3( Random.Range(xMin, xMax), 0f, Random.Range(zMin, zMax)), Quaternion.identity);
			}
			else if (randomNumber>=25 && randomNumber<50){
				// Spawn a bamboo plant
				Instantiate (treePrefab1, new Vector3( Random.Range(xMin, xMax), 0f, Random.Range(zMin, zMax)), Quaternion.identity);
			}
			else if (randomNumber>=50 && randomNumber<70){
				// Spawn a bamboo plant
				Instantiate (treePrefab2, new Vector3( Random.Range(xMin, xMax), 0f, Random.Range(zMin, zMax)), Quaternion.identity);
			}
			else if (randomNumber>=70 && randomNumber<90){
				// Spawn a bamboo plant
				Instantiate (treePrefab3, new Vector3( Random.Range(xMin, xMax), 0f, Random.Range(zMin, zMax)), Quaternion.identity);
			}
			else{
				// Spawn a bamboo plant
				Instantiate (treePrefab4, new Vector3( Random.Range(xMin, xMax), 0f, Random.Range(zMin, zMax)), Quaternion.identity);
			}
			// increment counter
			counter++;	
		}	
		if (Input.GetKey (KeyCode.Space)) {
			Application.LoadLevel (0);
		}
	}
}
