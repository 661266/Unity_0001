
using System.Collections;
using UnityEngine;

namespace KID.Class8
{
    public class Prop : MonoBehaviour,ICanUse
    {
        public Data data;
        public void Use()
        {
            print("使用道具:" + data.name);
            //開啟協同程序(協程方法)
            StartCoroutine(Big());
        }
        /// <summary>
        /// 協同程序方法:傳回類型IEnumerator
        /// 必須傳回時間
        /// yield return new WaitForSeconds(秒數);
        /// </summary>
        /// <returns></returns>
        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;
            while (player.lossyScale.x < 10) 
            {
                player.localScale += Vector3.one * 0.5f;
                yield return new WaitForSeconds(1);
            }
           
        }
    }
}
