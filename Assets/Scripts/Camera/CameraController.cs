using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float scrollSpeed, zoomSpeed, maxZoomIn, maxZoomOut,maxScrollBoundLeftX, maxScrollBoundRightX,maxScrollBoundUpY, maxScrollBoundDownY;

    private float zoom = -50;
    
    private float cameraPositionX = 0, cameraPositionY = 0;
    private GameObject camera;
    

    // Start is called before the first frame update
    void Start()
    {
        camera = gameObject;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraMovement();
        MouseZoom();
        MouseMovement();
    }   

    public void CameraMovement()
    {
        camera.transform.position = new Vector3(cameraPositionX, cameraPositionY, zoom);
    }

    public void MouseMovement()
    {
        if(Input.GetMouseButton(2))
        {
            if(Input.GetAxis("Mouse X") != 0)
            {
                cameraPositionX -= Input.GetAxis("Mouse X") * scrollSpeed * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse Y") != 0)
            {
                cameraPositionY -= Input.GetAxis("Mouse Y") * scrollSpeed * Time.deltaTime;
            }
        }

        cameraPositionX = Mathf.Clamp(cameraPositionX, maxScrollBoundLeftX, maxScrollBoundRightX);
        cameraPositionY = Mathf.Clamp(cameraPositionY, maxScrollBoundDownY, maxScrollBoundUpY);
    }

    private void MouseZoom()
    {
        if(Input.mouseScrollDelta.y < 0)
        {
            zoom -= zoomSpeed * Time.deltaTime;
        }
        if (Input.mouseScrollDelta.y > 0)
        {
            zoom += zoomSpeed * Time.deltaTime;
        }

        zoom = Mathf.Clamp(zoom, maxZoomOut, maxZoomIn);
    }
}
