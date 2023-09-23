using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    //定义刚体变量
    private Rigidbody drawline;
    //定义射线
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //获取光线组件
        lineRenderer = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //设置终点可视光线的始终点
        lineRenderer.SetPosition(0, this.transform.position);
        lineRenderer.SetPosition(1, this.transform.position + this.transform.forward * 8);
    }
}
