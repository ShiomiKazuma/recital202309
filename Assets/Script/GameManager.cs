using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>“ú•t‚Ìİ’è</summary>
    /// <summary>Œ‚Ìİ’è</summary>
    public int _mouse = 7;
    /// <summary>“ú‚Ìİ’è</summary>
    public int _date = 31;
    /// <summary>“ú•t—p‚ÌUI</summary>
    [SerializeField] GameObject _dateObject;
    Text _dateText;
    // Start is called before the first frame update
    void Start()
    {
        _dateText = _dateObject.GetComponent<Text>();
        _dateText.text = _mouse + "Œ" + _date + "“ú";
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

        _dateText.text = _mouse + "Œ" + _date + "“ú";
        Debug.Log(_dateText.text);
    }
}
