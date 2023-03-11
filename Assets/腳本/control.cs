using UnityEngine;

namespace ctl
{
    public class control : MonoBehaviour
    {
        [SerializeField, Header("目標物件")]
        private Transform target;
        private void Update()
        {
            LookAtTarget();
        }
        /// <summary>
        /// 面向
        /// </summary>
        private void LookAtTarget()
        {
            //面向
            //target
            transform.LookAt(target);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);        }

    }
}
