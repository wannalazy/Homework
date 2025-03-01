using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;

namespace WRX
{
    /// <summary>
    /// CetCard 類別：模擬抽卡遊戲邏輯
    /// </summary>
    public class CetCard : MonoBehaviour
    {
        // 用來記錄抽卡次數的變數
        private int totalDraws = 0;

        // 用來記錄每種卡片的數量
        private int EXCardCount = 0;
        private int SCardCount = 0;
        private int RCardCount = 0;
        private int FCardCount = 0;
        private int NCardCount = 0;

        // 每一幀更新時執行的函式
        private void Update()
        {
            // 單抽：如果是左鍵點擊
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                // 隨機生成一個範圍數字
                int randomNumber = Random.Range(1, 200200);

                // 呼叫 Range 函式來處理單抽邏輯
                Range(randomNumber);
            }

            // 十抽：如果是右鍵點擊
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                // 進行十次抽卡
                for (int i = 0; i < 10; i++)
                {
                    // 隨機生成一個範圍數字
                    int randomNumber = Random.Range(1, 200200);

                    // 呼叫 Range 函式來處理十抽邏輯
                    Range(randomNumber);
                }
            }
        }

        // 根據隨機數字範圍來確定抽到的卡片種類
        private void Range(int range)
        {
            // 每次抽卡，總次數加 1
            totalDraws++;

            // 根據隨機數字的範圍，決定抽到的卡片種類
            // 如果範圍大於等於 200000，抽到 EX 卡片並通關
            if (range >= 200000)
            {
                EXCardCount++;
                Debug.Log("<color=#FFA500>獲取卡片:EX，恭喜通關遊戲!!!<color>");
                Debug.Log("<color=#FFA500>0.001%機率<color>");

                // 顯示統計資訊並結束遊戲
                ShowStatistics();
                return;
            }

            // 如果範圍在 190000 到 200000 之間，抽到 S 卡片
            else if (range >= 190000 && range < 200000)
            {
                SCardCount++;
                Debug.Log("<color=#800080>獲取卡片:S，差一點了!!!</color>");
                Debug.Log("<color=#800080>10%機率</color>");
            }

            // 如果範圍在 170000 到 190000 之間，抽到 R 卡片
            else if (range >= 170000 && range < 190000)
            {
                RCardCount++;
                Debug.Log("<color=#0000FF>獲取卡片:R，還可以還可以!!!</color>");
                Debug.Log("<color=#0000FF>20%的機率</color>");
            }

            // 如果範圍在 90000 到 170000 之間，抽到 F 卡片
            else if (range >= 90000 && range < 170000)
            {
                FCardCount++;
                Debug.Log("<color=#00FF00>獲取卡片:F，比非洲人好一點而已~~<color>");
                Debug.Log("<color=#00FF00>40%的機率<color>");
            }

            // 如果範圍在 1 到 90000 之間，抽到 N 卡片
            else if (range >= 1 && range < 90000)
            {
                NCardCount++;
                Debug.Log("<color=#808080>獲取卡片:N，非洲人~~~跟你的人生一樣~~~<color>");
                Debug.Log("<color=#808080>45%的機率<color>");
            }
        }

        // 顯示抽卡統計資訊
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

            // 顯示遊戲結束訊息
            Debug.Log("<color=#FF0000>遊戲結束！<color>");

            // 結束遊戲或關閉應用程式
            EditorApplication.isPlaying = false;
        }
    }
}


