using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float _speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(_speed * Time.deltaTime, 0, 0);
    }

}
