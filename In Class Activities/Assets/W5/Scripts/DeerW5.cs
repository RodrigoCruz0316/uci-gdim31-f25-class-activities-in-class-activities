using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW6 : MonoBehaviour
{
[SerializeField] private float _speed = 3.5f;
[SerializeField] private float _rotationSpeed = 10f;
[SerializeField] private Transform _target;
[SerializeField] private float _stoppingDistance = 1.5f;
[SerializeField] private Vector3 _targetposition;
[SerializeField] private NavMeshAgent _Agent;
private NavMeshAgent _navMeshAgent;

private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.speed = _speed;
        _navMeshAgent.angularSpeed = _rotationSpeed;
        _navMeshAgent.SetDestination(_target.position);
    }
    private void Update()
    {
        if (_navMeshAgent.remainingDistance <= _stoppingDistance)
        {
            _navMeshAgent.isStopped = true;
        }
        else
        {
            _navMeshAgent.isStopped = false;
            _navMeshAgent.SetDestination(_target.position);
            _Agent.SetDestination(_target.position);
        }
    }
}

