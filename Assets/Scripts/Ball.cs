using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 100.0f;
    private Rigidbody2D _rigidbody2DBall;
    
    private void Awake()
    {
        _rigidbody2DBall = GetComponent<Rigidbody2D>();
    }
    
    private void Start() {
        ResetPosition();
        AddStartingForce();
    }
    
    public void ResetPosition() {
        _rigidbody2DBall.position = Vector2.zero;
        _rigidbody2DBall.velocity = Vector2.zero;
    }
    
    public void AddStartingForce() {
        var x = Random.value < 0.5 ? -1.0f : 1.0f;
        var y = Random.value < 0.5 ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f,1.0f);
        var direction = new Vector2(x, y);
        
        _rigidbody2DBall.AddForce(direction * speed);
    }
    
    public void SetForce(Vector2 force) {
        _rigidbody2DBall.AddForce(force);
    }

}
