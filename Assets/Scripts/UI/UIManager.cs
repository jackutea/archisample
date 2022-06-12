using System;
using UnityEngine;
using UnityEngine.UI;
using ArchiSample.Models;

namespace ArchiSample.Manager {

    public class UIManager {

        // 不需要拖拽绑定
        Canvas canvas;

        // 预制件
        UIPageLogin uiPageLoginPrefab;

        public void Inject(Canvas canvas) {
            this.canvas = canvas;
        }

        public void Init(UIPageLogin uiPageLogin) {
            this.uiPageLoginPrefab = uiPageLogin;
        }

        // 打开登录页
        public UIPageLogin OpenLogin() {
            UIPageLogin page = GameObject.Instantiate(uiPageLoginPrefab, canvas.transform);
            return page;
        }

    }

}