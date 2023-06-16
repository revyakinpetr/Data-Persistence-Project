using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public TextMeshProUGUI playerNameInput;

    // Start is called before the first frame update
    void Start()
    {
        if (DataManager.Instance != null)
        {
            playerNameInput.text = DataManager.Instance.PlayerName;
        }
    }

    public void StartGame()
    {
        DataManager.Instance.PlayerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }
}
