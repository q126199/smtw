using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//ʵ�֡�������Ϸ�������Ķ�������

public class UI_Manager : MonoBehaviour
{
    //��ȡ��Ϸ����
    public GameObject PlayingPanel;

    //��ȡ��ʼ����
    public GameObject StartPanel;
    //��ȡ��ʼ��Ϸ����
    public GameObject StartButton;
    //��ȡ�˳���Ϸ����
    public GameObject ExitButton_StartPanel;

    //��ȡ��ͣ����
    public GameObject PausePanel;
    //��ȡ������Ϸ����
    public GameObject ContinnueButton;
    //��ȡ�˳���Ϸ����
    public GameObject ExitButton_PausePanel;

    //��ȡʤ������
    public GameObject VictoryPanel;
    //��ȡ������Ϸ����
    public GameObject RestartButton_VictoryPanel;
    //��ȡ�˳���Ϸ����
    public GameObject ExitButton_VictoryPanel;

    //��ȡʧ�ܽ���
    public GameObject FailurePanel;
    //��ȡ������Ϸ����
    public GameObject RestartButton_FailurePanel;
    //��ȡ�˳���Ϸ����
    public GameObject ExitButton_FailurePanel;

    // Start is called before the first frame update
    void Start()
    {
        //������Ϸ��ʼ����
        StartPanel.SetActive(true);
        //��Ϸ��ͣ
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //����Esc����ͣ��Ϸ
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //�ر���Ϸ���
            PlayingPanel.SetActive(false);
            //������ͣ����
            PausePanel.SetActive(true);
            //��Ϸ��ͣ
            Time.timeScale = 0;
        }
    }

    //�Զ��庯�� ʵ�� ����Ϸ��ʼ�������Ĺ���
    public void GameStart()
    {
        //�ر���Ϸ��ʼ����
        StartPanel.SetActive(false);
        //��Ϸ����
        Time.timeScale = 1;
        //������Ϸ���
        PlayingPanel.SetActive(true);
    }

    //�Զ��庯�� ʵ�� ���˳���Ϸ�������Ĺ���
    public void GameEdit()
    {
        //�˳���Ϸ
        Application.Quit();
    }

    public void GameContinnue()
    {
        //�ر���ͣ����
        PausePanel.SetActive(false);
        //��Ϸ����
        Time.timeScale = 1;
        //������Ϸ���
        PlayingPanel.SetActive(true);
    }

    //�Զ��庯�� ʵ�� ��������Ϸ���Ȱ����Ĺ���
    public void GameRestart()
    {
        //��ȡ/���� 0�ų���
        SceneManager.LoadScene(0);
    }
}
