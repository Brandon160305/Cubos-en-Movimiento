using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float velocidad = 10f;

    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movHorizontal, 0.0f, movVertical);
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}