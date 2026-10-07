# <a id="Divine_Api_ApiField_1"></a> Class ApiField<T\>

Namespace: [Divine.Api](Divine.Api.md)  
Assembly: Divine.dll  

```csharp
public sealed class ApiField<T> : ApiMember where T : unmanaged
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ApiMember](Divine.Api.ApiMember.md) ← 
[ApiField<T\>](Divine.Api.ApiField\-1.md)

#### Inherited Members

[ApiMember.Name](Divine.Api.ApiMember.md\#Divine\_Api\_ApiMember\_Name), 
[ApiMember.IsValid](Divine.Api.ApiMember.md\#Divine\_Api\_ApiMember\_IsValid), 
[ApiMember.Offset](Divine.Api.ApiMember.md\#Divine\_Api\_ApiMember\_Offset), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<ApiField<T\>\>\(ApiField<T\>, params ApiField<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Methods

### <a id="Divine_Api_ApiField_1_GetAddress_Divine_Memory_INative_"></a> GetAddress\(INative\)

```csharp
public nint GetAddress(INative classPointer)
```

#### Parameters

`classPointer` [INative](Divine.Memory.INative.md)

#### Returns

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Api_ApiField_1_GetAddress_System_IntPtr_"></a> GetAddress\(nint\)

```csharp
public nint GetAddress(nint classPointer)
```

#### Parameters

`classPointer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Api_ApiField_1_GetInline_Divine_Memory_INative_"></a> GetInline\(INative\)

```csharp
public T* GetInline(INative classPointer)
```

#### Parameters

`classPointer` [INative](Divine.Memory.INative.md)

#### Returns

 T\*

### <a id="Divine_Api_ApiField_1_GetInline_System_IntPtr_"></a> GetInline\(nint\)

```csharp
public T* GetInline(nint classPointer)
```

#### Parameters

`classPointer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 T\*

### <a id="Divine_Api_ApiField_1_GetPointer_Divine_Memory_INative_"></a> GetPointer\(INative\)

```csharp
public void* GetPointer(INative classPointer)
```

#### Parameters

`classPointer` [INative](Divine.Memory.INative.md)

#### Returns

 [void](https://learn.microsoft.com/dotnet/api/system.void)\*

### <a id="Divine_Api_ApiField_1_GetPointer_System_IntPtr_"></a> GetPointer\(nint\)

```csharp
public void* GetPointer(nint classPointer)
```

#### Parameters

`classPointer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 [void](https://learn.microsoft.com/dotnet/api/system.void)\*

### <a id="Divine_Api_ApiField_1_GetValue_Divine_Memory_INative_"></a> GetValue\(INative\)

```csharp
public T GetValue(INative classPointer)
```

#### Parameters

`classPointer` [INative](Divine.Memory.INative.md)

#### Returns

 T

### <a id="Divine_Api_ApiField_1_GetValue_System_IntPtr_"></a> GetValue\(nint\)

```csharp
public T GetValue(nint classPointer)
```

#### Parameters

`classPointer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 T

### <a id="Divine_Api_ApiField_1_GetValueRef_Divine_Memory_INative_"></a> GetValueRef\(INative\)

```csharp
public ref T GetValueRef(INative classPointer)
```

#### Parameters

`classPointer` [INative](Divine.Memory.INative.md)

#### Returns

 T

### <a id="Divine_Api_ApiField_1_GetValueRef_System_IntPtr_"></a> GetValueRef\(nint\)

```csharp
public ref T GetValueRef(nint classPointer)
```

#### Parameters

`classPointer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

#### Returns

 T

### <a id="Divine_Api_ApiField_1_SetValue_Divine_Memory_INative__0_"></a> SetValue\(INative, T\)

```csharp
public void SetValue(INative classPointer, T value)
```

#### Parameters

`classPointer` [INative](Divine.Memory.INative.md)

`value` T

### <a id="Divine_Api_ApiField_1_SetValue_System_IntPtr__0_"></a> SetValue\(nint, T\)

```csharp
public void SetValue(nint classPointer, T value)
```

#### Parameters

`classPointer` [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

`value` T

