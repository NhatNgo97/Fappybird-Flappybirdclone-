using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    
    private Rigidbody2D rb;
    private float velocity = 7f;
    private bool _isDead = false;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Debug.Log(rb.gravityScale);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(0,0,25)), 1f);
            rb.velocity = Vector2.up * velocity;       
        }
    }
    

    void FixedUpdate() {
        if (rb.velocity.y < -3.5f){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(0,0,-90)), 0.025f);
        }
    }

    public bool isDead(){
        return _isDead;
    }

    public void Dead(){
        _isDead = true;
        gameManager.GameOver();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Dead();
    }

}
