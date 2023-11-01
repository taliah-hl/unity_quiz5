using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _time = 1f;
    //GameManager gameManager;
    void Awake ()
    {
        //gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("touced!" +other.tag );
        if (other.CompareTag("Player"))
        {
           Debug.Log("touched flag");
           StartCoroutine(ReloadScene(_time));
        }
    }

    public IEnumerator ReloadScene(float t)
    {
        yield return new WaitForSeconds(t);
        GameManager.Restart();

    }
}
