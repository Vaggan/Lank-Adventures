using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator anim;
    public float movementSpeed = 10f;

    private Rigidbody2D rbody;

    // Use this for initialization
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * movementSpeed * 10);
    }
}