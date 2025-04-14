using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    void Start() 
    {
        SceneManager.LoadScene(1); 
    }
}
