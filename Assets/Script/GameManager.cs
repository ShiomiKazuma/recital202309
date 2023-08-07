using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>���t�̐ݒ�</summary>
    /// <summary>���̐ݒ�</summary>
    public int _mouse = 7;
    /// <summary>���̐ݒ�</summary>
    public int _date = 31;
    /// <summary>���t�p��UI</summary>
    [SerializeField] GameObject _dateObject;
    Text _dateText;
    // Start is called before the first frame update
    void Start()
    {
        _dateText = _dateObject.GetComponent<Text>();
        _dateText.text = _mouse + "��" + _date + "��";
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

        _dateText.text = _mouse + "��" + _date + "��";
        Debug.Log(_dateText.text);
    }
}
