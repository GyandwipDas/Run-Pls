
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //reference to rigidbody rb
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysforce = 1000f;
    //used fixed because we mess around with unity physics 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
    {
        rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
    {
        rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (rb.position.y < -2.5f)
    {
        FindObjectOfType<GameManager>().EndGame();
    }

    }
    
}

