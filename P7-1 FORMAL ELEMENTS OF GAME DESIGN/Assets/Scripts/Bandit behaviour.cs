using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GLU.steering;

public class Banditbehaviour : MonoBehaviour
{

    private Steering steering;
    [SerializeField] private GameObject target;
    void Start()
    {

        steering = GetComponent<Steering>();

        List<IBehavior> behaviors = new List<IBehavior>();

        behaviors.Add(new Pursue(target));
        behaviors.Add(new FollowWall());
        behaviors.Add(new AvoidWall());

        steering.SetBehaviors(behaviors);
    }


}
