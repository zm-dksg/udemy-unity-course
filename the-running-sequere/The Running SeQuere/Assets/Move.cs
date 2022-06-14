using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField] float moveSpeed = 2f;

    void Start() {
    }

    void Update() {

        float finalSpeed = moveSpeed * Time.deltaTime;
        float xSpeed = Input.GetAxis("Horizontal") * finalSpeed;
        float zSpeed = Input.GetAxis("Vertical") * finalSpeed;

        transform.Translate(xSpeed, 0f, zSpeed);
    }
}
