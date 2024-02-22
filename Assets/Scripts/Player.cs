using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public float jumpForce = 5f;

    [Header("Audio effects")]
    public AudioClip jumpSound;
    public AudioClip dieSound;
    public AudioClip scoreSound;

    private Rigidbody2D rb;
    private AudioSource audioSource;
            
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && rb.velocity.y < 0)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            audioSource.PlayOneShot(jumpSound);
        }
        if(rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(x:0, y:0, z:30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(x: 0, y: 0, z: -30);
        }
    }
}
