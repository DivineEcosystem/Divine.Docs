# <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState"></a> Class CGameNetworkingUI\_GlobalState

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameNetworkingUI_GlobalState : IMessage<CGameNetworkingUI_GlobalState>, IEquatable<CGameNetworkingUI_GlobalState>, IDeepCloneable<CGameNetworkingUI_GlobalState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameNetworkingUI\_GlobalState](Divine.Protobufs.Steam.CGameNetworkingUI\_GlobalState.md)

#### Implements

IMessage<CGameNetworkingUI\_GlobalState\>, 
[IEquatable<CGameNetworkingUI\_GlobalState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameNetworkingUI\_GlobalState\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CGameNetworkingUI\_GlobalState\>\(CGameNetworkingUI\_GlobalState, params CGameNetworkingUI\_GlobalState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState__ctor"></a> CGameNetworkingUI\_GlobalState\(\)

```csharp
public CGameNetworkingUI_GlobalState()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState__ctor_Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_"></a> CGameNetworkingUI\_GlobalState\(CGameNetworkingUI\_GlobalState\)

```csharp
public CGameNetworkingUI_GlobalState(CGameNetworkingUI_GlobalState other)
```

#### Parameters

`other` [CGameNetworkingUI\_GlobalState](Divine.Protobufs.Steam.CGameNetworkingUI\_GlobalState.md)

## Properties

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_Parser"></a> Parser

```csharp
public static MessageParser<CGameNetworkingUI_GlobalState> Parser { get; }
```

#### Property Value

 MessageParser<[CGameNetworkingUI\_GlobalState](Divine.Protobufs.Steam.CGameNetworkingUI\_GlobalState.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_Clone"></a> Clone\(\)

```csharp
public CGameNetworkingUI_GlobalState Clone()
```

#### Returns

 [CGameNetworkingUI\_GlobalState](Divine.Protobufs.Steam.CGameNetworkingUI\_GlobalState.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_Equals_Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_"></a> Equals\(CGameNetworkingUI\_GlobalState\)

```csharp
public bool Equals(CGameNetworkingUI_GlobalState other)
```

#### Parameters

`other` [CGameNetworkingUI\_GlobalState](Divine.Protobufs.Steam.CGameNetworkingUI\_GlobalState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_MergeFrom_Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_"></a> MergeFrom\(CGameNetworkingUI\_GlobalState\)

```csharp
public void MergeFrom(CGameNetworkingUI_GlobalState other)
```

#### Parameters

`other` [CGameNetworkingUI\_GlobalState](Divine.Protobufs.Steam.CGameNetworkingUI\_GlobalState.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_GlobalState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

