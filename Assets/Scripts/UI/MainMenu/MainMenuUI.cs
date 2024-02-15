using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace mainMenu {
    public class MainMenuUI : UIBehaviour
    {
        [Header("Main Menu Buttons")]
        [SerializeField] private Button newGameBtn;
        [SerializeField] private Button loadBtn, exitbtn;

        [Header("Panels")]
        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private GameObject newGamePanel, loadPanel;

        public void OnNewGameBtnPressed()
        {
            mainMenuPanel.SetActive(false);
            newGamePanel.SetActive(true);

            Debug.Log("OnNewGameBtnPressed");
        }

        public void OnLoadBtnPressed()
        {
            Debug.Log("OnLoadBtnPressed");
        }

        public void OnExitBtnPressed()
        {
            Application.Quit();
            Debug.Log("OnExitBtnPressed");
        }

        [Header("New Game Panel Buttons")]
        [SerializeField] private GameObject startBtn;
        [SerializeField] private GameObject backFromNewGameBtn;

        [Header("New Game Scene")]
        [SerializeField] private int sceneIndex;

        public void OnStartBtnPressed()
        {
            SceneManager.LoadScene(sceneIndex);
            Debug.Log("OnStartBtnPressed");
        }

        public void OnBackFromNewGameBtnPressed()
        {
            newGamePanel.SetActive(false);
            mainMenuPanel.SetActive(true);
            Debug.Log("OnBackFromNewGameBtnPressed");
        }
    }
}