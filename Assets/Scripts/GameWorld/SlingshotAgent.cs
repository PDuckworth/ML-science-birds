using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents; 
using Unity.MLAgents.Actuators;

public class SlingshotAgent : Agent
{
    public override void OnActionReceived(ActionBuffers actions) {
            
            float SlingshotPower = actions.ContinuousActions[0];
            float SlingshotAngle = actions.ContinuousActions[1];
        }

        // Debug.Log(SlingshotPower);

}
