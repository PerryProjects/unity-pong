

using System;
using UnityEngine;

public class ComputerPaddle : Paddle {
    public Rigidbody2D ball;
    
    private void FixedUpdate() {
        if (ball.velocity.x > 0.0f) {
            if (ball.position.y > transform.position.y) {
                Rigidbody2D.AddForce(Vector2.up * speed);
            } else if (ball.position.y < transform.position.y) {
                Rigidbody2D.AddForce(Vector2.down * speed);
            }
        } else {
            switch (Rigidbody2D.position.y) {
                case > 0.0f:
                    Rigidbody2D.AddForce(Vector2.down * speed);
                    break;
                case < 0.0f:
                    Rigidbody2D.AddForce(Vector2.up * speed);
                    break;
            }
        }
    }
}
