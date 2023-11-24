using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _restarButtom;
    [SerializeField] private Button _exitButtom;
    [SerializeField] private Player _player;

    private CanvasGroup _gameOverGroup;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _restarButtom.onClick.AddListener(OnRestartButtomClick);
        _exitButtom.onClick.AddListener(OnExitButtomClick);
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restarButtom.onClick.RemoveListener(OnRestartButtomClick);
        _exitButtom.onClick.RemoveListener(OnExitButtomClick);
    }


    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0f;
    }

    private void OnDied()
    {
        _gameOverGroup.alpha = 1f;
        Time.timeScale = 0;
    }

    private void OnRestartButtomClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    private void OnExitButtomClick()
    {
        Application.Quit();
    }
}
