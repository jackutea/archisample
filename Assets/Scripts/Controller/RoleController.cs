using System;
using UnityEngine;
using ArchiSample.Facades;
using ArchiSample.Models;

namespace ArchiSample.Controller {

    public class RoleController {

        public RoleController() { }

        public void Ctor() {

        }

        public void Init() {

        }

        public void Tick() {

            // 3. 根据玩家输入, 移动角色
            RoleEntity role = AllRepository.roleEntity;
            if (role != null) {
                role.Tick();
                if (Input.GetKey(KeyCode.Space)) {
                    role.Move();
                }
            }

            StartGameEvent ev = AllEventCenter.StartGameEvent;
            if (ev.IsTrigger) {
                ev.SetIsTrigger(false);
                SpawnRole(ev.chapter, ev.level);
            }

        }

        void SpawnRole(int chapter, int level) {

            RoleEntity role = AllManager.roleManager.SpawnRole();
            role.Init();

            AllRepository.roleEntity = role;

        }

    }

}