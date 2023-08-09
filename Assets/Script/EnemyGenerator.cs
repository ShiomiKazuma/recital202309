using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] List<Transform> _enemyPoint = new List<Transform>();
    [SerializeField] GameObject _enemyObject;
    float _timer;
    float _interval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > _interval)
        {
            int index = Random.Range(0, _enemyPoint.Count);
            Instantiate(_enemyObject, _enemyPoint[index].position, Quaternion.identity);
            _timer = 0;
        }
    }
}
