using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroScript : MonoBehaviour
{

    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, speed * Time.timeScale));

        if (transform.position.y >= 100f) {
            Destroy(this.gameObject);
        }
    }
}
