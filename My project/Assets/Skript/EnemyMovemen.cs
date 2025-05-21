using UnityEngine;
using UnityEngine.AI;

public class EnemyMovemen : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    public PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.MoveStart == true)
        {

            if (player != null)
            {
                navMeshAgent.SetDestination(player.position);
            }
        }
    }
}
