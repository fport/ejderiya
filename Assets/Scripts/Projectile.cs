using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2D;
    [SerializeField] private float speed;
    
    private float direction;
    private bool hit;
    private float lifetime;

    private Animator anim;
    private BoxCollider2D boxCollider;
    public bool pause = false; 

    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
        pause = !pause;
        }
        if (!pause){
        gameObject.transform.parent = null;
        if (hit) return;
        
        rigidbody2D.AddForce(gameObject.transform.right*speed*Time.deltaTime);
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed;
        lifetime += Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false);
    }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag =="Enemy")
        {
            //Sayacı buradan düşürebilirsin
            //gameobject yok olduğundan dolayı bunun yıkarısına functionlar ekleyebilirsiniz
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}