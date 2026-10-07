# <a id="Divine_Protobufs_Dota2_CUserMessageRequestState"></a> Class CUserMessageRequestState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageRequestState : IMessage<CUserMessageRequestState>, IEquatable<CUserMessageRequestState>, IDeepCloneable<CUserMessageRequestState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageRequestState](Divine.Protobufs.Dota2.CUserMessageRequestState.md)

#### Implements

IMessage<CUserMessageRequestState\>, 
[IEquatable<CUserMessageRequestState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageRequestState\>, 
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
[EnumerableExtensions.In<CUserMessageRequestState\>\(CUserMessageRequestState, params CUserMessageRequestState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState__ctor"></a> CUserMessageRequestState\(\)

```csharp
public CUserMessageRequestState()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState__ctor_Divine_Protobufs_Dota2_CUserMessageRequestState_"></a> CUserMessageRequestState\(CUserMessageRequestState\)

```csharp
public CUserMessageRequestState(CUserMessageRequestState other)
```

#### Parameters

`other` [CUserMessageRequestState](Divine.Protobufs.Dota2.CUserMessageRequestState.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageRequestState> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageRequestState](Divine.Protobufs.Dota2.CUserMessageRequestState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_Clone"></a> Clone\(\)

```csharp
public CUserMessageRequestState Clone()
```

#### Returns

 [CUserMessageRequestState](Divine.Protobufs.Dota2.CUserMessageRequestState.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_Equals_Divine_Protobufs_Dota2_CUserMessageRequestState_"></a> Equals\(CUserMessageRequestState\)

```csharp
public bool Equals(CUserMessageRequestState other)
```

#### Parameters

`other` [CUserMessageRequestState](Divine.Protobufs.Dota2.CUserMessageRequestState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_MergeFrom_Divine_Protobufs_Dota2_CUserMessageRequestState_"></a> MergeFrom\(CUserMessageRequestState\)

```csharp
public void MergeFrom(CUserMessageRequestState other)
```

#### Parameters

`other` [CUserMessageRequestState](Divine.Protobufs.Dota2.CUserMessageRequestState.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

