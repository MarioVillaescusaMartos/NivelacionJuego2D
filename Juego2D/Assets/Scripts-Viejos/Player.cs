using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float spaceshipVelocity;
    public int spaceshipHealth;
    public int speedRotation;
    public int shootVelocity;
    public GameObject explosion;
    public GameObject shoot;
    

    private Rigidbody2D rb;
    private Vector3 direction;
    private Rigidbody2D sh;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        spaceshipHealth = 10;
        shootVelocity = 10;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");
            oneShoot();

            
            //sh.MovePosition(transform.position * shootVelocity * Time.deltaTime);
        }

        direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("space"))
        {
            twoShots();
        }

        

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position += Quaternion.identity * transform.up * spaceshipVelocity * Time.deltaTime;
        rb.transform.Rotate(0, 0, -direction.x * speedRotation);
       
    }

    void oneShoot()
    {
        var s = Instantiate(shoot, transform.position, Quaternion.identity);
        s.GetComponent<Rigidbody2D>().AddForce(transform.up * shootVelocity);
    }

   void twoShots()
    {
        var s = Instantiate(shoot, transform.position/2, Quaternion.identity);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Meteor"))
        {
            spaceshipHealth = spaceshipHealth - 1;
            var e = Instantiate(explosion, transform.position, Quaternion.identity);
            //Destroy(e, 2.0f);
        }
    }
}
