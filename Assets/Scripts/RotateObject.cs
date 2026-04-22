using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private Transform objectToRotate;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private bool clockwise = true;
    [SerializeField] public UI_HolaMundo holaMundoScript;

    private bool isRotating = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToogleRotation()
    {
        isRotating = !isRotating;
        if (isRotating)
        {
            holaMundoScript.ChangeTextHM("Rotation Started");
        }
        else
        {
            holaMundoScript.ChangeTextHM("Rotation Stopped");
        }
    }
}
