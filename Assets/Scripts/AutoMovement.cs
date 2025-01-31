using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    // Singleton
    public static AutoMovement instance;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float jumpForce = 5.0f; 
    private Rigidbody rb;
    void Awake(){
        instance = this;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        SingleDirectionMovement();

        if(Input.GetKeyDown(KeyCode.Space)){
            NormalJump();
        }
    }

    private void SingleDirectionMovement(){
        // Move the object to the right
        transform.position += new Vector3(1, 0, 0) * speed *Time.deltaTime;
    }
    private void NormalJump(){
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
