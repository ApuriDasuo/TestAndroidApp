using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HistoryScenePresenter : MonoBehaviour
{
    //Inspector上でオブジェクトを設定する変数
    [SerializeField] public Text mTxtHistoory = null;
    [SerializeField] public Button mBtnMove = null;

    void Start()
    {
        //履歴テキスト設定
        mTxtHistoory.text = MakeHistoryText();
        //ボタンイベント設定
        mBtnMove.onClick.AddListener(() => {
            SceneManager.LoadScene("Play");
        });
    }

    /// <summary>
    /// 履歴テキスト設定
    /// </summary>
    /// <returns>履歴テキスト</returns>
    private string MakeHistoryText()
    {
        List<string> history = StopTimeSaveData.mTimeSaveList.Select((time,id) =>
        {
            return $"No.{id+1} : {time.ToString("F2")}";
        }).ToList();
        return string.Join("\n", history);
    }
}
