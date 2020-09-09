using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bmp_Start : MonoBehaviour
{
 
    void OnMouseDown ()
    {
        SceneManager.LoadScene ("Level 1");

    }
}
