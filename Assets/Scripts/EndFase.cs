using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFase : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.FindWithTag("LevelManager").GetComponent<LevelManager>().NextLevel();
        

    }
}
