using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {
    public float speed = 25;
    public GameObject ballprefab;
    // Use this for initialization
    private void FixedUpdate()
    {
        float vertPress = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;
        
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A)){
            GameObject newBall = Instantiate(ballprefab) as GameObject;
            newBall.transform.position = (new Vector2(0f, 25.0f));

        }



	}
}
