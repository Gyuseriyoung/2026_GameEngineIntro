using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class NewMonoBehaviourScript : MonoBehaviour
{
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float movespeed = 6.5f;
    public float jumpforce = 3f;
    private Rigidbody2D rb;
    private Animator myAnimator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("PlayScene_" + collision.name);

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("move", false);
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump (InputValue value)
    {
        if (value.isPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * movespeed);
        transform.Translate(Vector3.up * moveInput.y * Time.deltaTime * movespeed);

        if (moveInput.magnitude > 0)
        {
            myAnimator.SetBool("move", true);
        }
        else {
            myAnimator.SetBool("move", false);
        }
    }
}
