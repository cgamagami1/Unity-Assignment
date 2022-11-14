/*
 * (Colin Gamagami)
 * (Prototype 4)
 * (Handles the win and loss state)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private TextMeshProUGUI messageText;
    public TextMeshProUGUI waveText;
    private bool isStartTextVisibe = true;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isStartTextVisibe && Input.GetKeyDown(KeyCode.Space))
        {
            isStartTextVisibe = false;
            messageText.text = "";
        }

        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void Win()
    {
        isGameOver = true;
        messageText.text = "You win. Press R to restart";
    }

    public void Lose()
    {
        isGameOver = true;
        messageText.text = "You lose. Press R to restart";
    }
}
