using System;
using ArchiSample.Manager;

namespace ArchiSample.Facades {

    public static class AllManager {

        public static UIManager uiManager;
        public static RoleManager roleManager;

        public static void Ctor() {
            uiManager = null;
            roleManager = null;
        }

    }

}