using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatchManager : MonoBehaviour
{
    //Inspector上でオブジェクトを設定する変数
    [SerializeField] public Text mTxtTime = null;
    [SerializeField] public Button mBtnStart = null;
    [SerializeField] public Button mBtnStop = null;
    [SerializeField] public Button mBtnReset = null;

    //タイマー値管理用変数
    private bool mIsOkCount;
    private float mCountTime;

    /// <summary>
    /// クラス初期化
    /// </summary>
    public void Init()
    {
        //変数初期化
        mIsOkCount=false;
        mCountTime = 0;
        mTxtTime.text = "0.00";
        //ボタンイベント設定
        mBtnStart.onClick.AddListener(() => {
            //カウント開始
            mIsOkCount = true;
        });
        mBtnStop.onClick.AddListener(() => {
            //履歴に保持
            if(mCountTime > 0)
            {
                StopTimeSaveData.SaveTime(mCountTime);
            }
            //カウント停止
            mIsOkCount = false;
        });
        mBtnReset.onClick.AddListener(() => {
            //タイマー値クリア
            mCountTime = 0;
            mTxtTime.text = mCountTime.ToString("F2");
        });
    }

    /// <summary>
    /// タイマー値更新処理
    /// </summary>
    public void UpdateTimer()
    {
        //カウント中判定
        if (!mIsOkCount)
        {
            return;
        }
        //カウント加算して表示更新
        mCountTime += Time.deltaTime;
        mTxtTime.text = mCountTime.ToString("F2");
    }
}
