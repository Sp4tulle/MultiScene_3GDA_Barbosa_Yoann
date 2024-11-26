using UnityEngine;
using UnityEngine.Serialization;

public class Turret : MonoBehaviour
{
    public Rigidbody projectilePrefab;
    public float range = 5f;
    public float fireRate = 0.5f;
    public float launchVelocity = 20f;
    public Transform rotatingPartTransform;
    public Transform firePoint;
    
    [Header("Debug")]
    public bool drawGizmos = false;
    
    [SerializeField] private Transform playerTsfm;
    private float nextFireTime;

    private void Start()
    {
        GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
        playerTsfm = playerGO.transform;
    }

    private void Update()
    {
        //Si pas de player : r
        if (playerTsfm == null) 
            return;
        
        float dist = Vector3.Distance(rotatingPartTransform.position, playerTsfm.position);
        if (dist <= range)
        {
            //Look at player
            rotatingPartTransform.LookAt(playerTsfm.position);

            //Raycast dir and check if player is hit
            Vector3 start = rotatingPartTransform.position;
            Vector3 dir = rotatingPartTransform.forward;

            //Tirer un rayon :
            if (Physics.Raycast(start, dir, out RaycastHit hit, range))
            {
                Debug.DrawLine(start, hit.point, Color.red);

                //Si le transform de l'objet touché est le transform du joueur : 
                if (hit.transform == playerTsfm && Time.time > nextFireTime)
                {
                    nextFireTime = Time.time + fireRate;
                    Rigidbody projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
                    projectile.AddForce(firePoint.forward * launchVelocity, ForceMode.Impulse);
                }
                else
                {
                    Debug.DrawLine(start, hit.point, new Color(0.43f, 0.31f, 0.38f));
                }
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        if (!drawGizmos) return;
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(rotatingPartTransform.position, range);
    }
}