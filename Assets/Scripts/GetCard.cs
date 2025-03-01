using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;

namespace WRX
{
    public class CetCard : MonoBehaviour
    {
        private int totalDraws = 0;
        private int EXCardCount = 0;
        private int SCardCount = 0;
        private int RCardCount = 0;
        private int FCardCount = 0;
        private int NCardCount = 0;

        private void Update()
        {
           // if (Input.GetKeyUp(KeyCode.Mouse0))
            //{
                int randomNumber = Random.Range(1, 200200);
                Range(randomNumber);
            //}
        }

        private void Range(int range)
        {
            totalDraws++;

            if (range >= 200000)
            {
                EXCardCount++;
                Debug.Log("<color=#FFA500>獲取卡片:EX，恭喜通關遊戲!!!<color>");
                Debug.Log("<color=#FFA500>0.001%機率<color>");

                ShowStatistics();
                return;
            }

            else if (range >= 190000 && range < 200000)
            {
                SCardCount++;
                Debug.Log("<color=#800080>獲取卡片:S，差一點了!!!</color>");
                Debug.Log("<color=#800080>10%機率</color>");
            }

            else if (range >= 170000 && range < 190000)
            {
                RCardCount++;
                Debug.Log("<color=#0000FF>獲取卡片:R，還可以還可以!!!</color>");
                Debug.Log("<color=#0000FF>20%的機率</color>");
            }

            else if (range >= 90000 && range < 170000)
            {
                FCardCount++;
                Debug.Log("<color=#00FF00>獲取卡片:F，比非洲人好一點而已~~<color>");
                Debug.Log("<color=#00FF00>80%的機率<color>");
            }

            else if (range >= 1 && range < 90000)
            {
                NCardCount++;
                Debug.Log("<color=#808080>獲取卡片:N，非洲人~~~跟你的人生一樣~~~<color>");
                Debug.Log("<color=#808080>90%的機率<color>");
            }
        }

        private void ShowStatistics()
        {
            // 顯示抽卡統計
            Debug.Log("<color=#FF0000>抽卡統計：<color>");
            Debug.Log($"<color=#FF0000>總抽卡次數: {totalDraws}<color>");
            Debug.Log($"<color=#FF0000>EX卡片: {EXCardCount} 次<color>");
            Debug.Log($"<color=#FF0000>S卡片: {SCardCount} 次<color>");
            Debug.Log($"<color=#FF0000>R卡片: {RCardCount} 次<color>");
            Debug.Log($"<color=#FF0000>F卡片: {FCardCount} 次<color>");
            Debug.Log($"<color=#FF0000>N卡片: {NCardCount} 次<color>");

            // 結束遊戲或關閉應用程式
            Debug.Log("<color=#FF0000>遊戲結束！<color>");
            EditorApplication.isPlaying = false; // 結束程式
        }
    }
}


