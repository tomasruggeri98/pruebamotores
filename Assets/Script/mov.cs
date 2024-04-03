using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento de la bola

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Obtener los inputs de teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, 0f);

        // Aplicar el movimiento a la bola
        rb.AddForce(movimiento * velocidad);
    }
}
