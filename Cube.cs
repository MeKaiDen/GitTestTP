using UnityEngine;

public class Cube : MonoBehaviour
{
	private void Start()
	{
		Debug.log("Hey, I'm a Cube");
		
		tr.position = new Vector3(Random.Range(1;10),Random.Range(1;10),Random.Range(1;10));
	}
}