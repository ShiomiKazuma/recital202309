using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    float _disapperPoint = -17.0f;
    float _speed = 1.0f;
    GroundGenerator _generator = default;
    // Start is called before the first frame update
    void Start()
    {
        _generator = GameObject.Find("GroundGenerator").GetComponent<GroundGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(_speed * Time.deltaTime, 0, 0);
        if(this.gameObject.transform.position.x < _disapperPoint )
        {
            Destroy(gameObject);
            _generator.CreateGround();
        }
    }
}
