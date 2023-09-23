using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //定义人物动画
    private Animator animator;

    //获取游戏界面
    public GameObject PlayingPanel;
    //获取胜利界面
    public GameObject VictoryPanel;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //按住W键播放“往前跑”动画
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool(name: "RunForward", true);
        }
        else
        {
            animator.SetBool(name: "RunForward", false);
        }
        //按住A键播放“往左跑”动画
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool(name: "RunLeft", true);
        }
        else
        {
            animator.SetBool(name: "RunLeft", false);
        }
        //按住D键播放“往右跑”动画
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool(name: "RunRight", true);
        }
        else
        {
            animator.SetBool(name: "RunRight", false);
        }
        //按住S键播放“转身”动画
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool(name: "TurnAround", true);
        }
        else
        {
            animator.SetBool(name: "TurnAround", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //判定空物体碰撞物体的类型
        if (other.gameObject.tag == "TheEnd")
        {
            //如果玩家碰触终点，则游戏胜利
            //关闭游戏界面
            PlayingPanel.SetActive(false);
            //激活胜利界面
            VictoryPanel.SetActive(true);
            //游戏暂停
            Time.timeScale = 0;
        }
    }
}
