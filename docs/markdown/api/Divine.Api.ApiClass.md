# <a id="Divine_Api_ApiClass"></a> Class ApiClass

Namespace: [Divine.Api](Divine.Api.md)  
Assembly: Divine.dll  

```csharp
public class ApiClass : ApiMember
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ApiMember](Divine.Api.ApiMember.md) ← 
[ApiClass](Divine.Api.ApiClass.md)

#### Inherited Members

[ApiMember.Name](Divine.Api.ApiMember.md\#Divine\_Api\_ApiMember\_Name), 
[ApiMember.IsValid](Divine.Api.ApiMember.md\#Divine\_Api\_ApiMember\_IsValid), 
[ApiMember.Offset](Divine.Api.ApiMember.md\#Divine\_Api\_ApiMember\_Offset), 
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
[EnumerableExtensions.In<ApiClass\>\(ApiClass, params ApiClass\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Api_ApiClass_Size"></a> Size

```csharp
public int Size { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Api_ApiClass_StructureSize"></a> StructureSize

```csharp
public int StructureSize { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Api_ApiClass_Type"></a> Type

```csharp
public byte Type { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

## Methods

### <a id="Divine_Api_ApiClass_RegisterField__1_System_String_"></a> RegisterField<T\>\(string\)

```csharp
public ApiField<T> RegisterField<T>(string name) where T : unmanaged
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ApiField](Divine.Api.ApiField\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="Divine_Api_ApiClass_RegisterFunction_System_String_"></a> RegisterFunction\(string\)

```csharp
public ApiFunction RegisterFunction(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [ApiFunction](Divine.Api.ApiFunction.md)

