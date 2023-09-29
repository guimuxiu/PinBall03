using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // スコアを表示するテキスト
    private GameObject ScoreText;



    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

    }



    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    // Scoreを100で初期化する
    public int point = 100;

    //スコアを表示するテキスト
    public GameObject Scoretext = null;



    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        //ScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");


        if (other.gameObject.tag == "SmallStarTag")
        {
            this.point += 5;

            Debug.Log("小さい星に衝突");
            

            //ScoreTextに現在の得点を表示
            ScoreText.GetComponent<Text>().text = "" + this.point;

        }
        
        if (other.gameObject.tag == "LargeStarTag")
        {
            Debug.Log("大きい星に衝突");
            this.point += 100;
           

            //ScoreTextに現在の得点を表示
            ScoreText.GetComponent<Text>().text = "" + this.point;


        }
         if (other.gameObject.tag == "SmallCloudTag")
        {
            Debug.Log("小さい雲に衝突");
            this.point += 10;
            

            //ScoreTextに現在の得点を表示
            ScoreText.GetComponent <Text>().text=""+this.point;


        }
         if (other.gameObject.tag == "LargeCloudTag")
        {
            Debug.Log("大きい雲に衝突");
            this.point += 50;
            

            //ScoreTextに現在の得点を表示
            ScoreText.GetComponent<Text>().text = "" + this.point;


        }


    }







}