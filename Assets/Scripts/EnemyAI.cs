using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //[SerializeField] private float speed = 1.5f;
    //private Rigidbody2D rb;
    //Transform target;
    //Vector2 direction;

    //private bool hasLineOfSight = false;

    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    target = GameObject.Find("Player").transform;
    //}

    //private void Update()
    //{
    //    if (hasLineOfSight)
    //    {
    //        //direction = (target.position - transform.position).normalized;
    //        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    //    }
    //}

    //private void FixedUpdate()
    //{
    //    RaycastHit2D ray = Physics2D.Raycast(transform.position, target.position - transform.position);
    //    if(ray.collider != null)
    //    {
    //        hasLineOfSight = ray.collider.CompareTag("Player");
    //        // Remove this section after debugging
    //        if(hasLineOfSight)
    //        {
    //            Debug.DrawRay(transform.position, target.position - transform.position, Color.blue);
    //        }
    //        else
    //        {
    //            Debug.DrawRay(transform.position, target.position - transform.position, Color.red);
    //        }
    //    }
    //    if (target)
    //    {
    //        rb.linearVelocity = new Vector2(direction.x, direction.y) * speed;
    //    }
    //}

    //public enum State
    //{
    //    PATROLLING,
    //    CHASING
    //}
    //private State state = State.PATROLLING;
    //[SerializeField] private float speed = 1.5f;
    //private Rigidbody2D rb;
    //Transform target;
    //Vector2 direction;
    //[SerializeField] private Transform waypointParent;
    //[SerializeField] private float waitTime = 2f;
    //[SerializeField] private bool loopWayPoints = true;

    //private Transform[] waypoints;
    //private int currentWaypointIndex;
    //private bool isWaiting;

    //bool spottedPlayer;
    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody2D>();        
    //}
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    target = GameObject.Find("Player").transform;
    //    waypoints = new Transform[waypointParent.childCount];

    //    for (int i = 0; i < waypointParent.childCount; i++)
    //    {
    //        waypoints[i] = waypointParent.GetChild(i);
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (state == State.PATROLLING)
    //    {
    //        Patrolling();
    //    }
    //    if (state == State.CHASING)
    //    {
    //        Chasing();
    //    }
    //}

    //void Patrolling()
    //{
    //    if (isWaiting)
    //    {
    //        return;
    //    }
    //    MoveToWaypoint();
    //}

    //void Chasing()
    //{
    //    direction = (target.position - transform.position).normalized;
    //}

    //private void FixedUpdate()
    //{
    //    if (target)
    //    {
    //        rb.linearVelocity = new Vector2(direction.x, direction.y) * speed;
    //    }
    //}

    //void MoveToWaypoint()
    //{
    //    Transform target = waypoints[currentWaypointIndex];
    //    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    //    if(Vector2.Distance(transform.position, target.position) < 0.1f)
    //    {
    //        StartCoroutine(WaitAtWaypoint());
    //    }
    //}

    //IEnumerator WaitAtWaypoint()
    //{
    //    isWaiting = true;
    //    yield return new WaitForSeconds (waitTime);
    //    currentWaypointIndex = loopWayPoints ? (currentWaypointIndex + 1) % waypoints.Length : Mathf.Min(currentWaypointIndex + 1, waypoints.Length - 1);
    //    isWaiting = false;
    //}
}
