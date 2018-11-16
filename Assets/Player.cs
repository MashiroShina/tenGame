using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;

    private float movement = 0;
    
	// Update is called once per frame
	void Update ()
	{
         movement = Input.GetAxisRaw("Horizontal");
	}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.back,movement*Time.fixedDeltaTime*moveSpeed);
    }
    static int i=0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Finish")
        {
            Debug.Log(++i);
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
