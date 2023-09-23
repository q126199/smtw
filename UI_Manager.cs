using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//实现“重启游戏”按键的额外引用

public class UI_Manager : MonoBehaviour
{
    //获取游戏界面
    public GameObject PlayingPanel;

    //获取开始界面
    public GameObject StartPanel;
    //获取开始游戏按键
    public GameObject StartButton;
    //获取退出游戏按键
    public GameObject ExitButton_StartPanel;

    //获取暂停界面
    public GameObject PausePanel;
    //获取继续游戏按键
    public GameObject ContinnueButton;
    //获取退出游戏按键
    public GameObject ExitButton_PausePanel;

    //获取胜利界面
    public GameObject VictoryPanel;
    //获取重启游戏按键
    public GameObject RestartButton_VictoryPanel;
    //获取退出游戏按键
    public GameObject ExitButton_VictoryPanel;

    //获取失败界面
    public GameObject FailurePanel;
    //获取重启游戏按键
    public GameObject RestartButton_FailurePanel;
    //获取退出游戏按键
    public GameObject ExitButton_FailurePanel;

    // Start is called before the first frame update
    void Start()
    {
        //激活游戏开始界面
        StartPanel.SetActive(true);
        //游戏暂停
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //按下Esc键暂停游戏
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //关闭游戏面板
            PlayingPanel.SetActive(false);
            //激活暂停界面
            PausePanel.SetActive(true);
            //游戏暂停
            Time.timeScale = 0;
        }
    }

    //自定义函数 实现 “游戏开始”按键的功能
    public void GameStart()
    {
        //关闭游戏开始界面
        StartPanel.SetActive(false);
        //游戏继续
        Time.timeScale = 1;
        //激活游戏面板
        PlayingPanel.SetActive(true);
    }

    //自定义函数 实现 “退出游戏”按键的功能
    public void GameEdit()
    {
        //退出游戏
        Application.Quit();
    }

    public void GameContinnue()
    {
        //关闭暂停界面
        PausePanel.SetActive(false);
        //游戏继续
        Time.timeScale = 1;
        //激活游戏面板
        PlayingPanel.SetActive(true);
    }

    //自定义函数 实现 “重新游戏”等按键的功能
    public void GameRestart()
    {
        //读取/载入 0号场景
        SceneManager.LoadScene(0);
    }
}
