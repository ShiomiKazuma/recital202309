using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>日付の設定</summary>
    /// <summary>月の設定</summary>
    public int _mouse = 7;
    /// <summary>日の設定</summary>
    public int _date = 31;
    /// <summary>日付用のUI</summary>
    [SerializeField] GameObject _dateObject;
    Text _dateText;
    // Start is called before the first frame update
    void Start()
    {
        _dateText = _dateObject.GetComponent<Text>();
        _dateText.text = _mouse + "月" + _date + "日";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDate()
    {
        if(_date == 31)
        {
            _mouse++;
            _date = 1;
        }
        else
        {
            _date++;
        }

        _dateText.text = _mouse + "月" + _date + "日";
        Debug.Log(_dateText.text);
    }
}
