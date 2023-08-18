using System;
using System.Collections.Generic;
using Core.UI.Base;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Core.UI
{
    public class PresentController
    {
        public BasePresenter ActivePresenter;
        private Dictionary<Type, BasePresenter> presenters;
        private Transform generatePosition;
        
        public PresentController(BasePresenter[] basePresenters, Transform generatePosition)
        {
            this.generatePosition = generatePosition;
            presenters = new Dictionary<Type, BasePresenter>();
            foreach (var presenter in basePresenters)
            {
                presenters.Add(presenter.GetType(), presenter);
            }
        }
        
        public T Show<T>(IPresenterData data = null, Action onShow = null) where T : BasePresenter
        {
           BasePresenter presenterPrefab =  presenters[typeof(T)];
           if (presenterPrefab == null)
           {
               Debug.LogError($"{typeof(T)} Not contains");
           }
           BasePresenter presenter = Object.Instantiate(presenterPrefab, generatePosition);
           presenter.Show(data, onShow);
           ActivePresenter = presenter;
           return (T)ActivePresenter;
        }

        public void Clos(Action onClos = null)
        {
            ActivePresenter.Clos(onClos);
        }
    }
}