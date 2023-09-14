using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private Material m_matBottom;
    private Material m_matMid;
    private Material m_matTop;


    [SerializeField] private float m_speedBottom;
    [SerializeField] private float m_speedMid;
    [SerializeField] private float m_speedTop;

    private GameObject m_objBackGround;
    void Start()
    {
        m_objBackGround = GameObject.Find("BackGround");
        Transform trsBottom = m_objBackGround.transform.Find("Bottom");
        Transform trsMid = m_objBackGround.transform.Find("Middle");
        Transform trsTop = m_objBackGround.transform.Find("Top");

        SpriteRenderer sRBottom = trsBottom.GetComponent<SpriteRenderer>();
        SpriteRenderer sRMid = trsMid.GetComponent<SpriteRenderer>();
        SpriteRenderer sRTop = trsTop.GetComponent<SpriteRenderer>();

        m_matBottom = sRBottom.material;
        m_matMid = sRMid.material;
        m_matTop = sRTop.material;
    }

    void Update()
    {
       Vector2 vecBottom = m_matBottom.mainTextureOffset;
       Vector2 vecMid =    m_matMid.mainTextureOffset;
       Vector2 vecTop =    m_matTop.mainTextureOffset;

        vecBottom += new Vector2(0, m_speedBottom * Time.deltaTime);
        vecMid += new Vector2(0, m_speedMid * Time.deltaTime);
        vecTop += new Vector2(0, m_speedTop * Time.deltaTime);

        vecBottom.y = Mathf.Repeat(vecBottom.y, 1.0f); //Repeat 1이넘으면 0으로 다시 보내는코딩
        vecMid.y = Mathf.Repeat(vecMid.y, 1.0f); //Repeat 1이넘으면 0으로 다시 보내는코딩
        vecTop.y = Mathf.Repeat(vecTop.y, 1.0f); //Repeat 1이넘으면 0으로 다시 보내는코딩

        m_matBottom.mainTextureOffset = vecBottom;
        m_matMid.mainTextureOffset = vecMid;
        m_matTop.mainTextureOffset = vecTop;
    }
}
