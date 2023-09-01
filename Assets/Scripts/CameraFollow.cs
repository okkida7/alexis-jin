using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Drag your player GameObject here in the inspector
    public float smoothSpeed = 0.125f; // This determines the smoothness of the camera's movement
    public Vector3 offset; // This can be used to offset the position of the camera, if needed
    private bool shouldFollow = false;

    public void OnButtonPressed()
    {
        StartCoroutine(WaitToFollow());
    }
    private void LateUpdate()
    {
        if (target == null || !shouldFollow) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Ensure the camera remains in the 2D plane (i.e., doesn't change its z position)
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }

    IEnumerator WaitToFollow()
    {
        yield return new WaitForSeconds(1.5f);
        shouldFollow = true;
    }
}
