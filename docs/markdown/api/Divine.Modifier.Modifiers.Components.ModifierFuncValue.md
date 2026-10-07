# <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue"></a> Struct ModifierFuncValue

Namespace: [Divine.Modifier.Modifiers.Components](Divine.Modifier.Modifiers.Components.md)  
Assembly: Divine.dll  

```csharp
public readonly struct ModifierFuncValue
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EnumerableExtensions.ClearFlags<ModifierFuncValue\>\(ModifierFuncValue, ModifierFuncValue\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_ClearFlags\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.GetFlagDescription<ModifierFuncValue\>\(ModifierFuncValue\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlagDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetFlags<ModifierFuncValue\>\(ModifierFuncValue\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_GetFlags\_\_1\_\_\_0\_), 
[EnumerableExtensions.In<ModifierFuncValue\>\(ModifierFuncValue, params ModifierFuncValue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_), 
[EnumerableExtensions.SetFlags<ModifierFuncValue\>\(ModifierFuncValue, ModifierFuncValue, bool\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_SetFlags\_\_1\_\_\_0\_\_\_0\_System\_Boolean\_)

## Properties

### <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue_Single"></a> Single

```csharp
public float Single { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue_Text"></a> Text

```csharp
public string Text { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue_Type"></a> Type

```csharp
public ModifierFuncValueType Type { get; }
```

#### Property Value

 [ModifierFuncValueType](Divine.Modifier.Modifiers.Components.ModifierFuncValueType.md)

## Methods

### <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue_op_Explicit_Divine_Modifier_Modifiers_Components_ModifierFuncValue__System_String"></a> explicit operator string\(ModifierFuncValue\)

```csharp
public static explicit operator string(ModifierFuncValue value)
```

#### Parameters

`value` [ModifierFuncValue](Divine.Modifier.Modifiers.Components.ModifierFuncValue.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Modifier_Modifiers_Components_ModifierFuncValue_op_Implicit_Divine_Modifier_Modifiers_Components_ModifierFuncValue__System_Single"></a> implicit operator float\(ModifierFuncValue\)

```csharp
public static implicit operator float(ModifierFuncValue value)
```

#### Parameters

`value` [ModifierFuncValue](Divine.Modifier.Modifiers.Components.ModifierFuncValue.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

