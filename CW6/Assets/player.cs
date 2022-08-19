using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Animator run;
    public float inc;
    public float maxpo;
    public float minpo;
    int coin;
    int health = 3;
    public AudioSource src;
    public Text healthText;
    public  Text CoinText;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            
            Invoke( "Restart", 1f );
        }
         move();
        
        if(coin >= 5)
        {

            if(health < 3)
            {

                health += 1;
                coin -= 5;
                healthText.text = " Health = " + health.ToString();
            }
        }
       
        

    }

    void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpo, maxpo), transform.position.y, transform.position.z);
            run.SetBool("idel", true);


        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpo, maxpo), transform.position.y, transform.position.z);
            run.SetBool("idel", true);
        }
        else
        {
            run.SetBool("idel", false);
        }
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" )
        {
            
            health -= 1;
           
            healthText.text = " Health = " + health.ToString();
            Destroy(collision.gameObject);
            

        }
        if (collision.gameObject.tag == "Enemy" && health == 0)
        {
            src.Play();
        }
        
        if (collision.gameObject.tag == "Coin")
        {
            coin += 1;
            CoinText.text = " Coin = " + coin.ToString();
            Destroy( collision.gameObject);
        }


    }
        void Restart()
        {
        SceneManager.LoadScene("main menu");
        }


}