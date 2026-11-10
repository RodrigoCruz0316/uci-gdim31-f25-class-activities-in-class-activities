using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;
   [SerializeField] private Transform _playerTransform;

    private void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, 
       _playerTransform.position,
       _speed
       );
    }
    public void EnableChase()
    {
        enabled = true;
    }
    public void DisableChase()
    {
        enabled = false;
    }
}