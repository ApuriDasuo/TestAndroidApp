using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HistoryScenePresenter : MonoBehaviour
{
    //Inspector��ŃI�u�W�F�N�g��ݒ肷��ϐ�
    [SerializeField] public Text mTxtHistoory = null;
    [SerializeField] public Button mBtnMove = null;

    void Start()
    {
        //�����e�L�X�g�ݒ�
        mTxtHistoory.text = MakeHistoryText();
        //�{�^���C�x���g�ݒ�
        mBtnMove.onClick.AddListener(() => {
            SceneManager.LoadScene("Play");
        });
    }

    /// <summary>
    /// �����e�L�X�g�ݒ�
    /// </summary>
    /// <returns>�����e�L�X�g</returns>
    private string MakeHistoryText()
    {
        List<string> history = StopTimeSaveData.mTimeSaveList.Select((time,id) =>
        {
            return $"No.{id+1} : {time.ToString("F2")}";
        }).ToList();
        return string.Join("\n", history);
    }
}
