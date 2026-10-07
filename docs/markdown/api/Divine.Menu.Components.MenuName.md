# <a id="Divine_Menu_Components_MenuName"></a> Struct MenuName

Namespace: [Divine.Menu.Components](Divine.Menu.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly ref struct MenuName
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Divine_Menu_Components_MenuName__ctor_System_String_"></a> MenuName\(string\)

```csharp
[SetsRequiredMembers]
public MenuName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuName__ctor_System_String_System_String_"></a> MenuName\(string, string\)

```csharp
[SetsRequiredMembers]
public MenuName(string name, string displayText)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`displayText` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="Divine_Menu_Components_MenuName_DisplayText"></a> DisplayText

```csharp
public required string DisplayText { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Menu_Components_MenuName_Name"></a> Name

```csharp
public required string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Operators

### <a id="Divine_Menu_Components_MenuName_op_Implicit_System_ValueTuple_System_String_System_String___Divine_Menu_Components_MenuName"></a> implicit operator MenuName\(\(string Name, string DisplayText\)\)

```csharp
public static implicit operator MenuName((string Name, string DisplayText) menuName)
```

#### Parameters

`menuName` \([string](https://learn.microsoft.com/dotnet/api/system.string) [Name](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.name), [string](https://learn.microsoft.com/dotnet/api/system.string) [DisplayText](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.displaytext)\)

#### Returns

 [MenuName](Divine.Menu.Components.MenuName.md)

### <a id="Divine_Menu_Components_MenuName_op_Implicit_System_String__Divine_Menu_Components_MenuName"></a> implicit operator MenuName\(string\)

```csharp
public static implicit operator MenuName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [MenuName](Divine.Menu.Components.MenuName.md)

