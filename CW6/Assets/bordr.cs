using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bordr : MonoBehaviour
{
    int score  = 0;
    public Text text1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        score += 1;
        text1.text = " score = " + score.ToString();
        Destroy(collision.gameObject);

    }
}
