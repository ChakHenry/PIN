using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    private bool isGameOver = false;
    public PinSpawn pinSpawn;
    public Rotator rotator;
    public GameObject End_UI;
    public Button reset_B;

    private void Start()
    {
        GameObject.FindObjectOfType<PinSpawn>().SpawnPin(); //開始時生成針
    }



    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            pinSpawn.enabled = false;
            rotator.enabled = false;
            End_UI.SetActive(true);
        }
    }

  //  void SpawnPin()
  //  {
       // Instantiate(Pin, PinSpawn. transform.position, PinSpawn. transform.rotation);
   // }
    void Update()
    {
        
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void RB()
    {
       RestartGame();
    }
}
