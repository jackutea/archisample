using System;
using System.Threading.Tasks;
using ArchiSample.Assets;

namespace ArchiSample.Facades {

    public static class AllAssets {

        public static GameAssets gameAssets;

        public static void Ctor() {
            gameAssets = new GameAssets();
        }

    }
}