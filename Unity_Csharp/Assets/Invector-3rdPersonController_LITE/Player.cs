
using UnityEngine;
using UnityEngine.AI;

//命名空間
namespace KID.Class8
{
    public class Player : MonoBehaviour
    {
        public Transform hand;

        private void OnTriggerEnter(Collider other)
        {
            //不要使用介面寫法
            if (other.name == "道具" || other.name == "武器") Hit(other.GetComponentInParent<ICanUse>());

            //使用介面寫法
            if (other.GetComponentInParent<ICanUse>() != null) Hit(other.GetComponentInParent<ICanUse>());
        }
        private void Hit(ICanUse Use)
        {
            print("碰到了");
            Use.Use();
        }
    }



    }

