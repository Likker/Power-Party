using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float speed = 1; // speed in meters per second
	public float jump = 1;

	void Update(){
		Vector3 moveDir = Vector3.zero;
		moveDir.x = Input.GetAxisRaw ("Horizontal"); // get result of AD keys in X
		// move this object at frame rate independent speed:
		transform.position += moveDir * speed * Time.deltaTime;

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
		}
	}
}
