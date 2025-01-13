using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looky : MonoBehaviour
{
    [SerializeField]
    private float _sensitivity = 5f;
    private float _verticalRotation = 0f; // Acumula la rotación en el eje Y
    private float _maxLookAngle = 85f; // Ángulo máximo hacia arriba/abajo

    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y"); // Detecta el movimiento vertical del mouse
        _verticalRotation -= _mouseY * _sensitivity; // Restar para invertir la rotación (puedes invertir quitando el signo -)

        // Restringir la rotación vertical dentro del rango permitido
        _verticalRotation = Mathf.Clamp(_verticalRotation, -_maxLookAngle, _maxLookAngle);

        // Aplicar la rotación al eje X local (mirar hacia arriba/abajo)
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x = _verticalRotation;
        transform.localEulerAngles = newRotation;
    }
}
