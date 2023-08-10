using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandGenerator : MonoBehaviour
{
    [SerializeField] GameObject _standPrehab;
    float _timer;
    [SerializeField] float _interval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _interval = Time.deltaTime;
        if( _timer < _interval )
        {
            Instantiate(_standPrehab, this.transform.position, Quaternion.identity );
            _timer = 0;
            int random = Random.Range(1, 5);
            _interval = random;
        }
    }
}
