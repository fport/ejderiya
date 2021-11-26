using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] public GameObject fireball;
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;
        Instantiate(fireball,firePoint);

        
    }
    
}