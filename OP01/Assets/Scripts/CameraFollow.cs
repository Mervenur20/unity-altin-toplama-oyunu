using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;//kamerayla player arasındaki fark nedir
    }

    
    private void Update()
    {
        Vector3 targetPos = player.position + offset;//playerin konumuyla offset toplarsak targetPos konumunu buluyoruz.
        targetPos.x = 0; //target x ekseninde position 0 dır
        transform.position = targetPos;//targetPos konumunu kaeraya atıyoruz
    }
}
