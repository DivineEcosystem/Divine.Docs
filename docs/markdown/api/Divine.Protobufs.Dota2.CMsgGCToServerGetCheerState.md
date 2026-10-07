# <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState"></a> Class CMsgGCToServerGetCheerState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerGetCheerState : IMessage<CMsgGCToServerGetCheerState>, IEquatable<CMsgGCToServerGetCheerState>, IDeepCloneable<CMsgGCToServerGetCheerState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerGetCheerState](Divine.Protobufs.Dota2.CMsgGCToServerGetCheerState.md)

#### Implements

IMessage<CMsgGCToServerGetCheerState\>, 
[IEquatable<CMsgGCToServerGetCheerState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerGetCheerState\>, 
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
[EnumerableExtensions.In<CMsgGCToServerGetCheerState\>\(CMsgGCToServerGetCheerState, params CMsgGCToServerGetCheerState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState__ctor"></a> CMsgGCToServerGetCheerState\(\)

```csharp
public CMsgGCToServerGetCheerState()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState__ctor_Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_"></a> CMsgGCToServerGetCheerState\(CMsgGCToServerGetCheerState\)

```csharp
public CMsgGCToServerGetCheerState(CMsgGCToServerGetCheerState other)
```

#### Parameters

`other` [CMsgGCToServerGetCheerState](Divine.Protobufs.Dota2.CMsgGCToServerGetCheerState.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerGetCheerState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerGetCheerState](Divine.Protobufs.Dota2.CMsgGCToServerGetCheerState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerGetCheerState Clone()
```

#### Returns

 [CMsgGCToServerGetCheerState](Divine.Protobufs.Dota2.CMsgGCToServerGetCheerState.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_Equals_Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_"></a> Equals\(CMsgGCToServerGetCheerState\)

```csharp
public bool Equals(CMsgGCToServerGetCheerState other)
```

#### Parameters

`other` [CMsgGCToServerGetCheerState](Divine.Protobufs.Dota2.CMsgGCToServerGetCheerState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_"></a> MergeFrom\(CMsgGCToServerGetCheerState\)

```csharp
public void MergeFrom(CMsgGCToServerGetCheerState other)
```

#### Parameters

`other` [CMsgGCToServerGetCheerState](Divine.Protobufs.Dota2.CMsgGCToServerGetCheerState.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerGetCheerState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

