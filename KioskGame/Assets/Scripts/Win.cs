using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private int numCorrect;

    public GameObject Correct;
    // Start is called before the first frame update
    void Start()
    {
        Correct.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (numCorrect == 3)
        {
            Correct.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }
    public void AddPoints()
    {
        numCorrect++;
        Debug.Log(numCorrect);
    }
    public void Exit()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
