using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D _rb;
    int _groundCount;
    [SerializeField] float _jumpPower = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        _groundCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && _groundCount < 2)
        {
            Vector2 vector = _rb.velocity;
            vector.y = _jumpPower;
            _rb.AddForce(vector, ForceMode2D.Impulse);
            _groundCount++;
            Debug.Log("ƒWƒƒƒ“ƒv");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _groundCount = 0;
        }
    }
}
