using System;
using ArchiSample.Models;

namespace ArchiSample.Facades {

    // 静态类
    // 缓存类
    public static class AllRepository {

        public static UIPageLogin uiPageLogin;
        public static RoleEntity roleEntity;

        public static void Ctor() {
            uiPageLogin = null;
            roleEntity = null;
        }

    }

}