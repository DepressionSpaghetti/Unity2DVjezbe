using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class MovementExample : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _grav = -9.8f;
    [SerializeField] private float _verVelocity = 0; 



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //_verVelocity += -_grav * Time.fixedDeltaTime;
        //Vector2 position = _rigidbody.position;
        //position.x += _speed * Time.fixedDeltaTime;
        //position.y = _verVelocity;
        //_rigidbody.MovePosition(position);

        Vector2 force = new Vector2(_speed, 0);
        _rigidbody.AddForce(force, ForceMode2D.Force);
    }


}
