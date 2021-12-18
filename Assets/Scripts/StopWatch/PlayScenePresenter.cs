using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScenePresenter : MonoBehaviour
{
    //Inspector��ŃI�u�W�F�N�g��ݒ肷��ϐ�
    [SerializeField] public StopWatchManager mSwMngr = null;
    [SerializeField] public Button mBtnMove = null;

    //���Q�l�T�C�g
    //��Unity�̃C�x���g���C�t�T�C�N��
    //https://watablog.tech/2019/09/20/post-492/
    //��Update�AFixedUpdate�̈Ⴂ
    //https://www.sejuku.net/blog/49382

    // �V�[���N�����ɌĂ΂��
    void Start()
    {
        //�X�g�b�v�E�H�b�`�N���X������
        mSwMngr.Init();
        //�{�^���C�x���g�ݒ�
        mBtnMove.onClick.AddListener(() => {
            SceneManager.LoadScene("History");
        });
    }

    // �s����Ȏ��ԂŌĂ΂��
    void Update()
    {
        mSwMngr.UpdateTimer();
    }

    // ��莞�ԂŌĂ΂��
    void FixedUpdate()
    {

    }

}
