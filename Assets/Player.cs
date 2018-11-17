using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    public Text score;
    private float movement = 0;
    public Slider Slider;
	// Update is called once per frame
	void Update ()
    {
        movement = Slider.value;
         //movement = Input.GetAxisRaw("Horizontal");
	}
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.back,movement*Time.fixedDeltaTime*moveSpeed);
    }
    private int i=0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        i++;
        score.transform.DOShakeScale(0.3f, 4);
        score.text = i.ToString();
        if (collision.tag=="Finish")
        {
          //  Debug.Log(++i);
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
