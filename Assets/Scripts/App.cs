using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArchiSample.Controller;
using ArchiSample.Facades;
using ArchiSample.Manager;
using ArchiSample.Models;

namespace ArchiSample.Main {

    // 静态阅读代码
    // 主入口
    // 用 Controller 把 App 的业务分离出去
    public class App : MonoBehaviour {

        bool isInit;

        MainController mainController;
        RoleController roleController;

        // 整个程序唯一一个入口
        // 其他地方不需要第二个Start, 除非很熟练
        // 一个Update
        void Start() {

            isInit = false;

            // ==== CTOR(Construct) ====
            // 实始化 Facades
            AllAssets.Ctor();
            AllRepository.Ctor();
            AllManager.Ctor();
            AllEventCenter.Ctor();

            mainController = new MainController();
            mainController.Ctor();

            roleController = new RoleController();
            roleController.Ctor();

            // ==== INJECT ====
            // 管理器缓存进AllManager
            AllManager.roleManager = new RoleManager();
            AllManager.uiManager = new UIManager();
            AllManager.uiManager.Inject(transform.GetComponentInChildren<Canvas>());

            // ==== INIT(Initialize) ====
            // 注意执行顺序
            // 异步
            Action action = async () => {

                // 启动了子线程来处理异步任务
                try {

                    await mainController.Init();
                    roleController.Init();

                    isInit = true;

                } catch {

                    Debug.LogError("出错啦");

                }

            };
            action.Invoke();

        }

        void Update() {

            if (!isInit) {
                return;
            }

            // 执行顺序
            mainController.Tick();
            roleController.Tick();

        }

    }

}

