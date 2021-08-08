using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource source;
    public GameObject cameraTarget;
    public float movementIntensity;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    public bool isfinished = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var forward = cameraTarget.transform.forward;
        var right = cameraTarget.transform.right;

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Gamescene");
            Scorescript.resetscore();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (isfinished == false)
        {
            Scorescript.updateScore();
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce (forward * movementIntensity);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce (-forward * movementIntensity);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce (right * movementIntensity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce (-right * movementIntensity);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            source.Play();
            }
        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("Gamescene");
            Scorescript.resetscore();
        }
    }
    void OnTriggerEnter(Collider other) 
    {
        isfinished = true;    
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void OnCollisionExit()
    {
        isGrounded = false;
    }
}
