//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using src.libs.src.ctxs.meta.services.components;

public partial class MetaContext {

    public MetaEntity selectionServiceEntity { get { return GetGroup(MetaMatcher.SelectionService).GetSingleEntity(); } }
    public SelectionServiceComponent selectionService { get { return selectionServiceEntity.selectionService; } }
    public bool hasSelectionService { get { return selectionServiceEntity != null; } }

    public MetaEntity SetSelectionService(src.libs.src.services.core.selection.ISelectionService newSelection) {
        if (hasSelectionService) {
            throw new Entitas.EntitasException("Could not set SelectionService!\n" + this + " already has an entity with src.libs.src.components.meta.SelectionServiceComponent!",
                "You should check if the context already has a selectionServiceEntity before setting it or use context.ReplaceSelectionService().");
        }
        var entity = CreateEntity();
        entity.AddSelectionService(newSelection);
        return entity;
    }

    public void ReplaceSelectionService(src.libs.src.services.core.selection.ISelectionService newSelection) {
        var entity = selectionServiceEntity;
        if (entity == null) {
            entity = SetSelectionService(newSelection);
        } else {
            entity.ReplaceSelectionService(newSelection);
        }
    }

    public void RemoveSelectionService() {
        selectionServiceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaEntity {

    public SelectionServiceComponent selectionService { get { return (SelectionServiceComponent)GetComponent(MetaComponentsLookup.SelectionService); } }
    public bool hasSelectionService { get { return HasComponent(MetaComponentsLookup.SelectionService); } }

    public void AddSelectionService(src.libs.src.services.core.selection.ISelectionService newSelection) {
        var index = MetaComponentsLookup.SelectionService;
        var component = CreateComponent<SelectionServiceComponent>(index);
        component.selection = newSelection;
        AddComponent(index, component);
    }

    public void ReplaceSelectionService(src.libs.src.services.core.selection.ISelectionService newSelection) {
        var index = MetaComponentsLookup.SelectionService;
        var component = CreateComponent<SelectionServiceComponent>(index);
        component.selection = newSelection;
        ReplaceComponent(index, component);
    }

    public void RemoveSelectionService() {
        RemoveComponent(MetaComponentsLookup.SelectionService);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MetaMatcher {

    static Entitas.IMatcher<MetaEntity> _matcherSelectionService;

    public static Entitas.IMatcher<MetaEntity> SelectionService {
        get {
            if (_matcherSelectionService == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.SelectionService);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherSelectionService = matcher;
            }

            return _matcherSelectionService;
        }
    }
}
