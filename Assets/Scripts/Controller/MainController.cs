using System;
using System.Threading.Tasks;
using UnityEngine;
using ArchiSample.Facades;
using ArchiSample.Manager;
using ArchiSample.Models;
using ArchiSample.Assets;

namespace ArchiSample.Controller {

    public class MainController {

        public MainController() { }

        public void Ctor() {

        }

        public void Inject(Canvas canvas) {
            AllManager.uiManager.Inject(canvas);
        }

        public async Task Init() {

            // 初始化
            GameAssets gameAssets = AllAssets.gameAssets;
            await gameAssets.LoadAllAssets();

            UIPageLogin prefab = gameAssets.GetUIPageLogin().GetComponent<UIPageLogin>();
            AllManager.uiManager.Init(prefab);

            RoleEntity rolePrefab = gameAssets.GetRolePrefab().GetComponent<RoleEntity>();
            AllManager.roleManager.Init(rolePrefab);

            // 业务逻辑
            // 完成的程序
            // 1. 打开UI, 点击按钮开始游戏
            UIPageLogin page = AllManager.uiManager.OpenLogin();
            page.OnStartGameHandle += OnStartGame; // 委托 - C 函数指针
            page.Init();

            AllRepository.uiPageLogin = page;

        }

        public void Tick() {
            if (Input.GetKeyUp(KeyCode.Escape)) {
                // 设置触发事件
                StartGameEvent ev = AllEventCenter.StartGameEvent;
                ev.chapter = 1;
                ev.level = 1;
                ev.SetIsTrigger(true);
            }
        }

        // ==== LOCAL EVENT ====
        // 2. 关闭UI & 生成角色
        void OnStartGame() {

            Debug.Log("开始游戏");

            GameObject.Destroy(AllRepository.uiPageLogin.gameObject);

            // 设置触发事件
            StartGameEvent ev = AllEventCenter.StartGameEvent;
            ev.chapter = 1;
            ev.level = 1;
            ev.SetIsTrigger(true);

        }

    }
}