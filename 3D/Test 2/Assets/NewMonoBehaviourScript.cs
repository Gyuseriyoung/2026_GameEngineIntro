using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float movespeed = 12.5f;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
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
    }
}
