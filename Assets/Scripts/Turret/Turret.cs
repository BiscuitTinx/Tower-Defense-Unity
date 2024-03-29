using System.Collections;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Transform target;
    private Enemy targetEnemy;

    private SpriteRenderer spriteRend;

    [Header("Unity Setup Fields")]

    public string enemyTag = "Enemy";

    public GameObject bulletPrefab;
    public Transform firePoint;

    [Header("Attributes")] 
    public float range = 15f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    void Awake()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sortingOrder = (int)-transform.position.y;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        //Targets enemy closest to turret
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            targetEnemy = nearestEnemy.GetComponent<Enemy>();
        }
        else
        {
            target = null;
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

        if (target == null)
        {
            return;
        }
        
    }

    void Shoot()
    {
        //shows bullet prefab a turret used into the game, this could include a spear, fireball and or lightning bolts
       GameObject bulletGO = (GameObject) Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       Bullet bullet = bulletGO.GetComponent<Bullet>();

       if (bullet != null)
       {
           bullet.Seek(target);
       }

    }

    void OnDrawGizmosSelected()
    {
        //Draws red radius on the turrets, this will also come in hand to show whether the enemies are in range
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
