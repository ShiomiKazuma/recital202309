using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] float _destroyTime = 2.0f;
    float _time = 0;
    private void Start()
    {
        _time = 0;
    }
    private void Update()
    {
        _time += Time.deltaTime;
        if (_time > _destroyTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("çUåÇÇ…ìñÇΩÇ¡ÇΩ");
            Destroy(collision.gameObject);
            
        }
    }

}
