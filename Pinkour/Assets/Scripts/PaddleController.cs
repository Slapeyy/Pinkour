using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    float restPosition = 0f;
    float pressedPosition = 45f;
    float flipperStrength = 10f;
    float flipperDamper = 1f;
    string inputButtonName = "LeftPaddle";

    private void Update()
    {
        JointSpring spring = new JointSpring();

        spring.spring = flipperStrength;
        spring.damper = flipperDamper;

        if (Input.GetButton(inputButtonName))
            spring.targetPosition = pressedPosition;
        else
            spring.targetPosition = restPosition;

        HingeJoint hingeJoint = new HingeJoint();

        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;

        JointLimits limit = new JointLimits();
        limit.min = restPosition;
        limit.max = pressedPosition;
    }
}
