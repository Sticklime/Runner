using System.Collections;
using UnityEngine;

namespace CodeBase.Bootstrapper
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}