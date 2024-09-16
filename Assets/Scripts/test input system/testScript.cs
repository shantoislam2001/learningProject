using UnityEngine;
using UnityEngine.InputSystem;

public class testScript : MonoBehaviour
{
    private Test playerInputActions;

    private void Awake()
    {
        playerInputActions = new Test();
    }

    private void OnEnable()
    {
        
        playerInputActions.Play.Enable();
        playerInputActions.Play.Print.performed += OnPrint;
    }

    private void OnDisable()
    { 
        playerInputActions.Play.Print.performed -= OnPrint;
        playerInputActions.Play.Disable();
    }

    private void OnPrint(InputAction.CallbackContext context)
    {
        
        Debug.Log("Clicked");
    }
}
