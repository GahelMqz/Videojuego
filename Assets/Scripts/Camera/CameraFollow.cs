using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //taget es nuevo jugador
    public Vector3 offset;


    private void LateUpdate()
    //comunmente se usa para movimientos de camara
    //se ejecuta casi al final)
    {
        transform.position = target.position + offset;
    }
}
