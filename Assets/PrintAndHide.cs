using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int blueDeactivateThreshold;

    void Start()
    {
        i++;
        if (gameObject.tag == "Blue")
        {
            blueDeactivateThreshold = Random.Range(150, 251); // 生成 150 到 250 之间的随机整数
        }
    }

    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false); // 停用红色游戏对象
        }

        if (gameObject.tag == "Blue")
        {
            if (i == blueDeactivateThreshold)
            {
                rend.enabled = false; // 在指定的阈值禁用 Renderer 组件
            }
            else if (i > blueDeactivateThreshold)
            {
                rend.enabled = true; // 在超过阈值后重新启用 Renderer 组件
            }
        }
    }
}


