using UnityEngine;

public class InfiniteRunner : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Velocidad de movimiento del piso

    void Update()
    {
        // Mover el piso hacia atrás
        transform.Translate(Vector3.back * velocidadMovimiento * Time.deltaTime);
    }
}
