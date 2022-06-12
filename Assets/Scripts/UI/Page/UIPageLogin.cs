using System;
using UnityEngine;
using UnityEngine.UI;

namespace ArchiSample {

    // UI: User Interface
    // 用户界面做两件事:
    // 1. 把用户输入, 反馈出去
    // 2. 显示
    // 
    // 不做的事:
    // 1. 处理逻辑
    public class UIPageLogin : MonoBehaviour {

        public Button startGameButton;

        // 一个是绑定, 由绑定者调用: += 
        // 一个触发, 调用Invoke()
        public event Action OnStartGameHandle;

        public void Init() {

            startGameButton.onClick.AddListener(() => {
                OnStartGameHandle.Invoke();
            });

        }

    }

}