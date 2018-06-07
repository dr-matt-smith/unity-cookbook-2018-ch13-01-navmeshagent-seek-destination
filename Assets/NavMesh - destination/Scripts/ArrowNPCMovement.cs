using UnityEngine;
using System.Collections;

public class ArrowNPCMovement : MonoBehaviour {
	public GameObject targetGO;
	private UnityEngine.AI.NavMeshAgent navMeshAgent;
	
	void Start()
	{
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		HeadForDestintation();
	}

	private void HeadForDestintation ()
	{
		Vector3 destinaton = targetGO.transform.position;
		navMeshAgent.SetDestination (destinaton);
	}
}
