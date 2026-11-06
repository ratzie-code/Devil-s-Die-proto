using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Camera Settings")]
    [SerializeField] private Transform playerCamera;

    [SerializeField] private float sensitivity = 0.1f;


    [SerializeField] private float minPitch = -60f;

    [SerializeField] private float maxPitch = 60f;

    private float yaw;
    private float pitch;

    private float startingYaw;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }


    private void Update()
    {
        if (Mouse.current == null) return;

        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        yaw+= mouseDelta.x * sensitivity;
       pitch+= mouseDelta.y * sensitivity;



        // Restrict horizontal camera movement to a 180-degrees
        yaw = Mathf.Clamp(yaw, - 90f, 90f);

        // Restrict vertical camera movement to a 180-degrees
        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);

        //Rotate the player horizontally
        transform.rotation = Quaternion.Euler(0f, startingYaw + yaw, 0f);


        //rotate the camera vertically
        playerCamera.localRotation = Quaternion.Euler(pitch, 0f, 0f);

    }


}
