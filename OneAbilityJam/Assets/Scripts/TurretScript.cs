using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public GameObject tiro;

    public Transform leftShooter, rightShooter;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction * Time.timeScale;

        if (Input.GetKeyDown("mouse 0") && Time.timeScale > 0)
        {
            //atirar
            Debug.Log("atirando");
            Instantiate(tiro, leftShooter.position, leftShooter.rotation);
            Instantiate(tiro, rightShooter.position, rightShooter.rotation);

        }

        /*Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);*/
    }
}
