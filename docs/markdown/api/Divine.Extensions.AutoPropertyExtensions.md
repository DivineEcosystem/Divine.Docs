# <a id="Divine_Extensions_AutoPropertyExtensions"></a> Class AutoPropertyExtensions

Namespace: [Divine.Extensions](Divine.Extensions.md)  
Assembly: Divine.dll  

```csharp
public static class AutoPropertyExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AutoPropertyExtensions](Divine.Extensions.AutoPropertyExtensions.md)

#### Inherited Members

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
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Extensions_AutoPropertyExtensions_GetAutoProperty_System_Reflection_FieldInfo_"></a> GetAutoProperty\(FieldInfo\)

```csharp
public static PropertyInfo? GetAutoProperty(this FieldInfo fieldInfo)
```

#### Parameters

`fieldInfo` [FieldInfo](https://learn.microsoft.com/dotnet/api/system.reflection.fieldinfo)

#### Returns

 [PropertyInfo](https://learn.microsoft.com/dotnet/api/system.reflection.propertyinfo)?

### <a id="Divine_Extensions_AutoPropertyExtensions_GetBackingField_System_Reflection_PropertyInfo_"></a> GetBackingField\(PropertyInfo\)

```csharp
public static FieldInfo? GetBackingField(this PropertyInfo propertyInfo)
```

#### Parameters

`propertyInfo` [PropertyInfo](https://learn.microsoft.com/dotnet/api/system.reflection.propertyinfo)

#### Returns

 [FieldInfo](https://learn.microsoft.com/dotnet/api/system.reflection.fieldinfo)?

### <a id="Divine_Extensions_AutoPropertyExtensions_IsAnAutoProperty_System_Reflection_PropertyInfo_"></a> IsAnAutoProperty\(PropertyInfo\)

```csharp
public static bool IsAnAutoProperty(this PropertyInfo propertyInfo)
```

#### Parameters

`propertyInfo` [PropertyInfo](https://learn.microsoft.com/dotnet/api/system.reflection.propertyinfo)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Extensions_AutoPropertyExtensions_IsBackingFieldOfAnAutoProperty_System_Reflection_FieldInfo_"></a> IsBackingFieldOfAnAutoProperty\(FieldInfo\)

```csharp
public static bool IsBackingFieldOfAnAutoProperty(this FieldInfo propertyInfo)
```

#### Parameters

`propertyInfo` [FieldInfo](https://learn.microsoft.com/dotnet/api/system.reflection.fieldinfo)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

