using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //定义刚体变量
    private Rigidbody monster;
    //定义滚石移动速度
    private float speed = 30f;

    //获取游戏界面
    public GameObject PlayingPanel;
    //获取失败界面
    public GameObject FailurePanel;

    //获取粒子特效
    public GameObject ExplosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //获取monster上的RigidBody组件
        monster = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //给滚石施加力
        monster.AddForce(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //判定滚石碰撞物体的类型
        if (other.gameObject.tag == "BarrierWall")
        {
            //如果滚石碰撞的是障碍墙，销毁它
            Destroy(other.gameObject);
            //生成爆炸特效
            GameObject prafab = GameObject.Instantiate(ExplosionPrefab, this.transform.position, Quaternion.identity);
            GameObject.Destroy(prafab, 2f);
        }
        else if (other.gameObject.tag == "Player")
        {
            //如果滚石碰撞的是玩家，则游戏失败
            //关闭游戏界面
            PlayingPanel.SetActive(false);
            //激活失败界面
            FailurePanel.SetActive(true);
            //游戏暂停
            Time.timeScale = 0;
        }
    }
}