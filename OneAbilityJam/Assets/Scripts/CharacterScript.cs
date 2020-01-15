using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public GameControl gameControl;

    public GameObject tiro;

    public Transform leftShooter, rightShooter;



    public int choice = 0;

    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (choice) {
            case 0:

                if (Input.GetKey("mouse 0")) {
                    transform.Translate(new Vector2(-speed * Time.timeScale, 0f));
                }

                if (Input.GetKey("mouse 1")) {
                    transform.Translate(new Vector2(speed * Time.timeScale, 0f));
                }

                break;

            case 1:

                if (Input.GetKeyDown("mouse 0")) {
                    //atirar
                    Debug.Log("atirando");
                    Instantiate(tiro, leftShooter.position, leftShooter.rotation);
                    Instantiate(tiro, rightShooter);

                }

                break;
        }
    }

    public void choose(int choice) {
        this.choice = choice;

        gameControl.despausar();
    }

}
