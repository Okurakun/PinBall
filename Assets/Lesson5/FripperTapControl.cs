using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperTapControl : MonoBehaviour {

    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;

    private float flickAngle = -20;

    void Start () {
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);
    }
	
	
	void Update () {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                   
                    SetAngle(this.flickAngle);

                    break;

                case TouchPhase.Ended:
                    SetAngle(this.defaultAngle);
                    break;
            }
             

        }
      


    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
