//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputActionMatcher {

    public static Entitas.IAllOfMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> AllOf(params Entitas.IMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>[] matchers) {
          return Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> AnyOf(params Entitas.IMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>[] matchers) {
          return Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>.AnyOf(matchers);
    }
}
