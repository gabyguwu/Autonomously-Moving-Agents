using UnityEngine;
using UnityEngine.InputSystem;   

public class Drive : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
    public float currentSpeed = 0f;

    void Update()
    {
        var kb = Keyboard.current;
        
      
        if (kb == null) return;

        float vertical = 0f;
        float horizontal = 0f;

        
        if (kb.wKey.isPressed || kb.upArrowKey.isPressed) vertical += 1f;
        if (kb.sKey.isPressed || kb.downArrowKey.isPressed) vertical -= 1f;

        
        if (kb.aKey.isPressed || kb.leftArrowKey.isPressed) horizontal -= 1f;
        if (kb.dKey.isPressed || kb.rightArrowKey.isPressed) horizontal += 1f;

        // Calcular desplazamiento y rotación
        float translation = vertical * speed * Time.deltaTime;
        float rotation = horizontal * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        currentSpeed = translation;
        transform.Rotate(0, rotation, 0);
    }
}