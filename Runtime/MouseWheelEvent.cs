#if UNITY_EDITOR

using System;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// マウスホイールのイベントを管理するクラス
    /// </summary>
    public sealed class MouseWheelEvent : MonoBehaviour
    {
        //================================================================================
        // プロパティ
        //================================================================================
        public Action OnUp   { get; set; }
        public Action OnDown { get; set; }

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 破棄されるときに呼び出されます
        /// </summary>
        private void OnDestroy()
        {
            OnUp   = null;
            OnDown = null;
        }

        /// <summary>
        /// 毎フレーム呼び出されます
        /// </summary>
        private void Update()
        {
            var callback = Input.mouseScrollDelta.y switch
            {
                < 0 => OnDown,
                > 0 => OnUp,
                _   => default,
            };

            callback?.Invoke();
        }
    }
}

#endif