using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {

    public enum motionDirections {Spin, Horizontal, Vertiacal}

    public motionDirections motionState = motionDirections.Horizontal;

    public float spinSpeed = 180f;

    public float motionMagnitude = 0.1f;

	// Update is called once per frame
	void Update () {
        switch (motionState)
        {
            case motionDirections.Spin:
                // Rotate around the up axis of the gameObject
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;
            case motionDirections.Vertiacal:
                // move up and down over time
                gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
            case motionDirections.Horizontal:
                // move right and left over time
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
        }
    }
}
