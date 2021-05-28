using System.Collections;
using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}