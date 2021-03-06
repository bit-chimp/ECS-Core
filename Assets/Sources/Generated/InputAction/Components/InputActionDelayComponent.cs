//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using src.libs.src.ctxs.general.delay.components;

public partial class InputActionEntity {

    public DelayComponent delay { get { return (DelayComponent)GetComponent(InputActionComponentsLookup.Delay); } }
    public bool hasDelay { get { return HasComponent(InputActionComponentsLookup.Delay); } }

    public void AddDelay(float newSeconds) {
        var index = InputActionComponentsLookup.Delay;
        var component = CreateComponent<DelayComponent>(index);
        component.seconds = newSeconds;
        AddComponent(index, component);
    }

    public void ReplaceDelay(float newSeconds) {
        var index = InputActionComponentsLookup.Delay;
        var component = CreateComponent<DelayComponent>(index);
        component.seconds = newSeconds;
        ReplaceComponent(index, component);
    }

    public void RemoveDelay() {
        RemoveComponent(InputActionComponentsLookup.Delay);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputActionEntity : IDelayEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputActionMatcher {

    static Entitas.IMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> _matcherDelay;

    public static Entitas.IMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> Delay {
        get {
            if (_matcherDelay == null) {
                var matcher = (Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>)Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>.AllOf(InputActionComponentsLookup.Delay);
                matcher.componentNames = InputActionComponentsLookup.componentNames;
                _matcherDelay = matcher;
            }

            return _matcherDelay;
        }
    }
}
