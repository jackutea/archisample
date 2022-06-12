using System;
using ArchiSample.Models;

namespace ArchiSample.Facades {

    public static class AllEventCenter {

        // 是否触发
        static StartGameEvent startGameEvent;
        public static StartGameEvent StartGameEvent => startGameEvent;
        public static void SetStartGameEvent(StartGameEvent ev) => startGameEvent = ev;

        public static void Ctor() {
            startGameEvent = new StartGameEvent();
        }

    }

}