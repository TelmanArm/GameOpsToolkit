using System;
using Core.UI.Base;
using UnityEngine;

namespace Core.UI
{
    public class BasePresenter : MonoBehaviour
    {
        public virtual void Show(IPresenterData date, Action onShow)
        {
            onShow?.Invoke();
        }

        public virtual void Clos(Action onClose)
        {
            onClose?.Invoke();
            Destroy(gameObject);
        }
    }
}