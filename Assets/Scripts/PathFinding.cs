using UnityEngine;
using System.Collections;

public class PathFinding : MonoBehaviour {

    public Transform[] targets;

    [Header("Baddy Properties: ")]
    [Space(5)]
    public int ID;
    public bool Enabled;

    [Header("Movement Properties: ")]
    [Space(5)]
    public float speed = 5.0f;
    public float readDist = 1.0f;
    public int currentPoint = 0;

    void Start()
    {
        if (ID == null)
            Enabled = false;

        if (ID != null)
            Enabled = true;
    }

    void Update()
    {
        
        Vector3 dir = targets[currentPoint].position - transform.position;

        if(Enabled)

        transform.position += dir * Time.deltaTime * speed;

        if (dir.magnitude <= readDist)
        {
            currentPoint++;
        }

        if (currentPoint >= targets.Length)
        {
            currentPoint = 0;
        }
    }

    void OnDrawGizmos()
    {
        if(targets.Length > 0)
        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i] != null)
            {
                Gizmos.DrawSphere(targets[i].position, readDist);
            }
        }
    }

    

}
