# <a id="Divine_Menu_EventArgs_AbilityTogglerChangedEventArgs"></a> Class AbilityTogglerChangedEventArgs

Namespace: [Divine.Menu.EventArgs](Divine.Menu.EventArgs.md)  
Assembly: Divine.dll  

```csharp
public class AbilityTogglerChangedEventArgs : TogglerChangedEventArgs<AbilityId>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[MenuEventArgs](Divine.Menu.EventArgs.MenuEventArgs.md) ← 
[MenuValueEventArgs<bool\>](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md) ← 
[TogglerKeyValueEventArgs<AbilityId\>](Divine.Menu.EventArgs.TogglerKeyValueEventArgs\-1.md) ← 
[TogglerChangedEventArgs<AbilityId\>](Divine.Menu.EventArgs.TogglerChangedEventArgs\-1.md) ← 
[AbilityTogglerChangedEventArgs](Divine.Menu.EventArgs.AbilityTogglerChangedEventArgs.md)

#### Inherited Members

[TogglerKeyValueEventArgs<AbilityId\>.Key](Divine.Menu.EventArgs.TogglerKeyValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_TogglerKeyValueEventArgs\_1\_Key), 
[MenuValueEventArgs<bool\>.Value](Divine.Menu.EventArgs.MenuValueEventArgs\-1.md\#Divine\_Menu\_EventArgs\_MenuValueEventArgs\_1\_Value), 
[MenuEventArgs.Behavior](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_Behavior), 
[MenuEventArgs.IsEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsEvent), 
[MenuEventArgs.IsAddEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsAddEvent), 
[MenuEventArgs.IsRemoveEvent](Divine.Menu.EventArgs.MenuEventArgs.md\#Divine\_Menu\_EventArgs\_MenuEventArgs\_IsRemoveEvent), 
[EventArgs.Empty](https://learn.microsoft.com/dotnet/api/system.eventargs.empty), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<AbilityTogglerChangedEventArgs\>\(AbilityTogglerChangedEventArgs, params AbilityTogglerChangedEventArgs\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_EventArgs_AbilityTogglerChangedEventArgs__ctor"></a> AbilityTogglerChangedEventArgs\(\)

```csharp
public AbilityTogglerChangedEventArgs()
```

### <a id="Divine_Menu_EventArgs_AbilityTogglerChangedEventArgs__ctor_Divine_Entity_Entities_Abilities_Components_AbilityId_System_Boolean_"></a> AbilityTogglerChangedEventArgs\(AbilityId, bool\)

```csharp
[SetsRequiredMembers]
public AbilityTogglerChangedEventArgs(AbilityId key, bool value)
```

#### Parameters

`key` [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

