using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Beweegt langs een Path
public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThreshold;

    private Path _path;
    private Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
    }

    private void Update()
    {
        transform.LookAt(_currentWaypoint.GetPosition());
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        
        
        // beschrijf in psuedo code of comments
        // wat moet gebeuren in de Update van PathFollower
        // hint, je hebt de variabelen nodig die in deze class gedefinieerd zijn...
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
    }
    
    private void PathComplete()
    {
        
    }
}