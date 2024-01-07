using System;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision) {
        var ball = collision.gameObject.GetComponent<Ball>();
        
        if (ball != null) {
            var normal = collision.GetContact(0).normal;
            ball.SetForce(-normal * bounceStrength);
        }
        
    }
}