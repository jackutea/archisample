using System;
using UnityEngine;
// 审查
// x using Facades

namespace ArchiSample.Models {

    // 同层独立的
    public class RoleEntity : MonoBehaviour {

        public void Init() {
            Debug.Log("角色已生成");
        }

        public void Tick() {
            
        }

        public void Move() {
            transform.position += Time.deltaTime * Vector3.right;
        }

    }

}