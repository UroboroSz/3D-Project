using UnityEngine;

public class Sc_PlayerController : MonoBehaviour
{
    //Variables
    private Vector3 mov, camRot;
    private bool canJump;
    private Rigidbody rb;

    public float movSpeed = 1000f;
    public float rotSpeed = 500f;
    public float jumpForce = 6f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Move geting H and V axis
        mov.x = Input.GetAxis("Horizontal");
        mov.z = Input.GetAxis("Vertical");

        rb.AddForce(mov * Time.deltaTime * movSpeed);

        //Jump
        //Raycast down to verify if is touching ground
        canJump = Physics.Raycast(transform.position, Vector3.down, 1f);

        if (Input.GetKeyDown(KeyCode.Space) && canJump) {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

        //Cam Rotation
        camRot.y = Input.GetAxis("Mouse X");

        transform.Rotate(camRot * Time.deltaTime * rotSpeed);
        
    }
}
