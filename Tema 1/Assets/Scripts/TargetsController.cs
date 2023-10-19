using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TargetsController : MonoBehaviour
{
    public Transform target1; 
    public Transform target2;
    public float proximityThreshold = 0.1f; 
    private Animator johnAnimator;
    private Animator jackAnimator;

    void Start()
    {
        johnAnimator = target1.GetComponent<Animator>();
        jackAnimator = target2.GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(target1.position, target2.position);
        if (distance < proximityThreshold)
        {
             if (johnAnimator != null && jackAnimator!= null)
             {
                johnAnimator.SetBool("IsAngry",true);
                jackAnimator.SetBool("IsAngry",true);
             }
        }
        else
        {
              if (johnAnimator != null && jackAnimator!= null)
             {
                johnAnimator.SetBool("IsAngry",false);
                jackAnimator.SetBool("IsAngry",false);
             }
        }
    }
}
