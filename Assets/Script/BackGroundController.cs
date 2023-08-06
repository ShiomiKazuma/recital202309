using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    /// <summary>�w�i</summary>
    [SerializeField] SpriteRenderer _backgroundSprite = null;
    /// <summary>�w�i�̃X�N���[�����x</summary>
    [SerializeField] float _scrollSpeedX = -1f;
    /// <summary>�w�i���N���[���������̂����Ă����ϐ�</summary>
    SpriteRenderer _backgroundSpriteClone;
    /// <summary>�w�i���W�̏����l</summary>
    float _initialPositionX;

    void Start()
    {
        _initialPositionX = _backgroundSprite.transform.position.x;   // ���W�̏����l��ۑ����Ă���

        // �w�i�摜�𕡐����ď�ɕ��ׂ�
        _backgroundSpriteClone = Instantiate(_backgroundSprite);
        _backgroundSpriteClone.transform.Translate(_backgroundSprite.bounds.size.x, 0f, 0f);
    }

    void Update()
    {
        // �w�i�摜���X�N���[������
        _backgroundSprite.transform.Translate(_scrollSpeedX * Time.deltaTime, 0f, 0f);
        _backgroundSpriteClone.transform.Translate(_scrollSpeedX * Time.deltaTime, 0f, 0f);

        // �w�i�摜��������x���ɍs������A�E�ɖ߂�
        if (_backgroundSprite.transform.position.x < _initialPositionX - _backgroundSprite.bounds.size.x)
        {
            _backgroundSprite.transform.Translate(_backgroundSprite.bounds.size.x * 2, 0f, 0f);
        }

        // �w�i�摜�̃N���[����������x���ɍs������A�E�ɖ߂�
        if (_backgroundSpriteClone.transform.position.x < _initialPositionX - _backgroundSpriteClone.bounds.size.x)
        {
            _backgroundSpriteClone.transform.Translate(_backgroundSpriteClone.bounds.size.x * 2, 0f, 0f);
        }
    }
}

