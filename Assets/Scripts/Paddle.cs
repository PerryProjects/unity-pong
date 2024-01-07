using UnityEngine;
using UnityEngine.Serialization;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D Rigidbody2D;

    [FormerlySerializedAs("_speed")] public float speed = 10.0f;

    private void Awake() {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition() {
        Rigidbody2D.position = new Vector2(Rigidbody2D.position.x, 0.0f);
        Rigidbody2D.velocity = Vector2.zero;
    }
}
