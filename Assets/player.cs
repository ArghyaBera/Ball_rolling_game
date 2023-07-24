using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    
    public Rigidbody ball;
    public float ballforce;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text=ball.position.z.ToString("0");
        ball.AddForce(0f, 0f, 5 * ballforce);
        if (Input.GetKey("a")) ball.AddForce(-2*ballforce, 0f, 0f);
        if (Input.GetKey("d")) ball.AddForce(2*ballforce, 0f, 0f);
        if(ball.position.y<-5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }
}
