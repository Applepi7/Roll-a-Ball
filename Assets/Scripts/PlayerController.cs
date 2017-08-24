using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static PlayerController instance;

    public float speed = 10.0f;

    private Rigidbody rigidbody;

    void Start()
    {
        PlayerController.instance = this;
        rigidbody = GetComponent<Rigidbody>();
    }

	void FixedUpdate () {
        Moving();
    }

    void Moving()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbody.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("PickUp"))
        {
            col.gameObject.SetActive(false);
            GameManager.instance.score++;
        } 
    }
}
