using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
[SerializeField] private int speed;
[SerializeField]private bool _chase = false;
[SerializeField]private float delta;
[SerializeField]private Vector3 _targetposition;
[SerializeField]private Vector3 _direction;
private void Start()
    {
        if (_chase)
        {
            _direction = (_targetposition - transform.position).normalized;
            transform.Translate(_direction * speed * Time.deltaTime);
        }
    }
    public void ChasePlayer(Vector3 playerposition)
    {
        _chase = true;
        _targetposition = playerposition;
    }
    public void StopChase()
    {
        _chase = false;
        _targetposition = Vector3.zero;
    }
}