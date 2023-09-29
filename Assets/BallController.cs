using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    // �X�R�A��\������e�L�X�g
    private GameObject ScoreText;



    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

    }



    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    // Score��100�ŏ���������
    public int point = 100;

    //�X�R�A��\������e�L�X�g
    public GameObject Scoretext = null;



    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {

        //ScoreText�I�u�W�F�N�g���擾
        this.ScoreText = GameObject.Find("ScoreText");


        if (other.gameObject.tag == "SmallStarTag")
        {
            this.point += 5;

            Debug.Log("���������ɏՓ�");
            

            //ScoreText�Ɍ��݂̓��_��\��
            ScoreText.GetComponent<Text>().text = "" + this.point;

        }
        
        if (other.gameObject.tag == "LargeStarTag")
        {
            Debug.Log("�傫�����ɏՓ�");
            this.point += 100;
           

            //ScoreText�Ɍ��݂̓��_��\��
            ScoreText.GetComponent<Text>().text = "" + this.point;


        }
         if (other.gameObject.tag == "SmallCloudTag")
        {
            Debug.Log("�������_�ɏՓ�");
            this.point += 10;
            

            //ScoreText�Ɍ��݂̓��_��\��
            ScoreText.GetComponent <Text>().text=""+this.point;


        }
         if (other.gameObject.tag == "LargeCloudTag")
        {
            Debug.Log("�傫���_�ɏՓ�");
            this.point += 50;
            

            //ScoreText�Ɍ��݂̓��_��\��
            ScoreText.GetComponent<Text>().text = "" + this.point;


        }


    }







}