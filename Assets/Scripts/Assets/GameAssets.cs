using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace ArchiSample.Assets {

    public class GameAssets {

        Dictionary<string, GameObject> uiAssets;
        Dictionary<string, GameObject> roleAssets;

        public GameAssets() {
            uiAssets = new Dictionary<string, GameObject>();
            roleAssets = new Dictionary<string, GameObject>();
        }

        // 架构
        // 搜关键词: C# Task / async / await
        public async Task LoadAllAssets() {

            // AA 包
            await LoadUI();

            await LoadRole();

        }

        // ==== LOAD ====
        async Task LoadUI() {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "UIAssets";
            IList<GameObject> res = await Addressables.LoadAssetsAsync<GameObject>(labelReference, null).Task;
            foreach (GameObject go in res) {
                uiAssets.Add(go.name, go);
            }
        }

        async Task LoadRole() {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "RoleAssets";
            IList<GameObject> res = await Addressables.LoadAssetsAsync<GameObject>(labelReference, null).Task;
            foreach (GameObject go in res) {
                roleAssets.Add(go.name, go);
            }
        }

        // ==== GET ====
        public GameObject GetUIPageLogin() {
            uiAssets.TryGetValue("UIPageLogin", out GameObject go);
            return go;
        }

        public GameObject GetRolePrefab() {
            roleAssets.TryGetValue("RoleEntity", out GameObject go);
            return go;
        }

    }

}