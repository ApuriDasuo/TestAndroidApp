using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatchManager : MonoBehaviour
{
    //Inspector��ŃI�u�W�F�N�g��ݒ肷��ϐ�
    [SerializeField] public Text mTxtTime = null;
    [SerializeField] public Button mBtnStart = null;
    [SerializeField] public Button mBtnStop = null;
    [SerializeField] public Button mBtnReset = null;

    //�^�C�}�[�l�Ǘ��p�ϐ�
    private bool mIsOkCount;
    private float mCountTime;

    /// <summary>
    /// �N���X������
    /// </summary>
    public void Init()
    {
        //�ϐ�������
        mIsOkCount=false;
        mCountTime = 0;
        mTxtTime.text = "0.00";
        //�{�^���C�x���g�ݒ�
        mBtnStart.onClick.AddListener(() => {
            //�J�E���g�J�n
            mIsOkCount = true;
        });
        mBtnStop.onClick.AddListener(() => {
            //�����ɕێ�
            if(mCountTime > 0)
            {
                StopTimeSaveData.SaveTime(mCountTime);
            }
            //�J�E���g��~
            mIsOkCount = false;
        });
        mBtnReset.onClick.AddListener(() => {
            //�^�C�}�[�l�N���A
            mCountTime = 0;
            mTxtTime.text = mCountTime.ToString("F2");
        });
    }

    /// <summary>
    /// �^�C�}�[�l�X�V����
    /// </summary>
    public void UpdateTimer()
    {
        //�J�E���g������
        if (!mIsOkCount)
        {
            return;
        }
        //�J�E���g���Z���ĕ\���X�V
        mCountTime += Time.deltaTime;
        mTxtTime.text = mCountTime.ToString("F2");
    }
}
