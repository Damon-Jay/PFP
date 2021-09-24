using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Is een verzamling van waypoints
// en biedt bepaalde toegang
public class Path : MonoBehaviour
{
    [SerializeField] private Waypoint[] _waypoints;

    public Waypoint GetPathStart()
    {
        return _waypoints[0];
    }

    public Waypoint GetPathEnd()
    {
        return _waypoints[_waypoints.Length - 1];
    }

    public Waypoint GetNextWaypoint(Waypoint currentWaypoint)
    {
        // dit is nu niet goed, moet ik nog aanpassen
        // maar heb dan geen error meer
        return _waypoints[0];
    }
}
