using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelController : MonoBehaviour
{
    public float speed = 15f;
    public float limiteEsquerdo = -8f;
    public float limiteDireito = 8f;

    void Update()
    {
        float moveX = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
            moveX = -1f;

        if (Keyboard.current.rightArrowKey.isPressed)
            moveX = 1f;

        transform.position += new Vector3(moveX * speed * Time.deltaTime, 0, 0);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, limiteEsquerdo, limiteDireito);
        transform.position = pos;
    }

}