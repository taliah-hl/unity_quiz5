using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;


public class BlueTileColor : MonoBehaviour
{
    [SerializeField] private Tilemap blueTile;
    private Vector4 solidBlue=new Vector4(4f, 59f, 92f, 1f);
    private Vector4 transBlue=new Vector4(4f, 59f, 92f, 0.5f);
    
    
    // Start is called before the first frame update
    void Start()
    {
        blueTile = GetComponent<Tilemap>();
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
