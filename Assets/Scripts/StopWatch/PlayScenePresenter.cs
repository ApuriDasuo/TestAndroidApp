using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScenePresenter : MonoBehaviour
{
    //Inspector上でオブジェクトを設定する変数
    [SerializeField] public StopWatchManager mSwMngr = null;
    [SerializeField] public Button mBtnMove = null;

    //◆参考サイト
    //▼Unityのイベントライフサイクル
    //https://watablog.tech/2019/09/20/post-492/
    //▼Update、FixedUpdateの違い
    //https://www.sejuku.net/blog/49382

    // シーン起動時に呼ばれる
    void Start()
    {
        //ストップウォッチクラス初期化
        mSwMngr.Init();
        //ボタンイベント設定
        mBtnMove.onClick.AddListener(() => {
            SceneManager.LoadScene("History");
        });
    }

    // 不定期な時間で呼ばれる
    void Update()
    {
        mSwMngr.UpdateTimer();
    }

    // 一定時間で呼ばれる
    void FixedUpdate()
    {

    }

}
