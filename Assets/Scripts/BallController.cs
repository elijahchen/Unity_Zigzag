using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    [SerializeField]
    private float speed;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb.velocity = new Vector3(speed, 0, 0);
	}

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SwitchDirection();
        }
	}

    void SwitchDirection()
    {
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        } else if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
}
