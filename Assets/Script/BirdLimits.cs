using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLimits : MonoBehaviour
{
	private Vector2 birdLimits;
	private float birdWidth;
	private float birdHeight;
	
    // Start is called before the first frame update
    void Start()
    {
        birdLimits = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        birdWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        birdHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, birdLimits.x * -1 + birdWidth/2, birdLimits.x - birdWidth/2);
        //viewPos.y = Mathf.Clamp(viewPos.y, birdLimits.y * -1 + birdHeight, birdLimits.y - birdHeight);
        //viewPos.y = Mathf.Clamp(viewPos.y, birdLimits.y * -1 + birdHeight, 9999999999);
        transform.position = viewPos;
    }
}
