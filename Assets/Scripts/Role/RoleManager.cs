using System;
using UnityEngine;
using ArchiSample.Models;

namespace ArchiSample.Manager {

    // 角色管理器
    public class RoleManager {

        RoleEntity rolePrefab;

        public void Init(RoleEntity rolePrefab) {
            this.rolePrefab = rolePrefab;
        }

        public RoleEntity SpawnRole() {
            RoleEntity role = GameObject.Instantiate(rolePrefab);
            return role;
        }

    }

}