using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    float horizontalMove;
    float verticalMove;
    private const float FLY_STEP = 3f;
    public UnityEngine.UI.Slider mainSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis ("Horizontal");

        if (mainSlider.value != 0)
        {
            verticalMove = Input.GetAxis("Jump");
        }
       
        
        transform.Translate(x, verticalMove, 0); 
         
         // Flip the Character:
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0) {
            characterScale.x = 1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = -1;
        }
        transform.localScale = characterScale;
        
        //Bird break fall
        if (Input.GetAxis("Jump") > 0)
        {
            if (mainSlider.value > 0)
            {
                Fly();
            }
        }
    }

    private void Fly() {
        transform.GetComponent<Rigidbody2D>().velocity = Vector3.up * FLY_STEP;

       // float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb.gravityScale));
        //rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}                                                                            
