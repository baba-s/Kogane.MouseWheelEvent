# Kogane Mouse Wheel Event

マウスホイールのイベントを管理するクラス

## 使用例

```csharp
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    [SerializeField] private MouseWheelEvent m_mouseWheelEvent;

    private void Awake()
    {
        m_mouseWheelEvent.OnUp   = () => Debug.Log( "Up" );
        m_mouseWheelEvent.OnDown = () => Debug.Log( "Down" );
    }
}
```