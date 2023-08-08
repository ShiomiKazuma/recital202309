using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    [SerializeField] GameObject gameObjects = null;
    public void CreateGround()
    {
        Instantiate(gameObjects,this.transform.position, Quaternion.identity);
    }
}
