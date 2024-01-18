using UnityEngine;

namespace Lesson4
{
    public abstract class AbstractLogger : MonoBehaviour
    {
        [SerializeField] protected string inspectorLogMes;

        public abstract void Print (string log);
    }
}