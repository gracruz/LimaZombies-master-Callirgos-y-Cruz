
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform followAt;
    public float distanceToFollow;
    public EnemySO data; 

    private NavMeshAgent mNavMeshAgent;
    private Animator mAnimator;

    private string Tipo;

   


    private void Awake()
    {
        mNavMeshAgent = GetComponent<NavMeshAgent>();

        Tipo = data.enemyName;
        if (Tipo.Equals("EnemyBig"))
        {
            mAnimator = transform.Find("Mutant").GetComponent<Animator>();
        }
        if (Tipo.Equals("EnemySmall"))
        {
            mAnimator = transform.Find("Zombie").GetComponent<Animator>();
        }

    }

    private void Start()
    {
        mNavMeshAgent.speed = data.speed;
        
    }

    private void Update()
    {
        //mNavMeshAgent.destination = followAt.position;
        float distance = Vector3.Distance(transform.position, followAt.position);
        if (distance <= distanceToFollow)
        {
            mNavMeshAgent.isStopped = false;
            mNavMeshAgent.destination = followAt.position;
            mAnimator.SetTrigger("Walk");
        }
        else
        {
            mAnimator.SetTrigger("Stop");
            mNavMeshAgent.isStopped = true;
        }

    }
}
