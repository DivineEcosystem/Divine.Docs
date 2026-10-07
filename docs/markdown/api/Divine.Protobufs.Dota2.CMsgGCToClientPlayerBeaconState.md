# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState"></a> Class CMsgGCToClientPlayerBeaconState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPlayerBeaconState : IMessage<CMsgGCToClientPlayerBeaconState>, IEquatable<CMsgGCToClientPlayerBeaconState>, IDeepCloneable<CMsgGCToClientPlayerBeaconState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPlayerBeaconState](Divine.Protobufs.Dota2.CMsgGCToClientPlayerBeaconState.md)

#### Implements

IMessage<CMsgGCToClientPlayerBeaconState\>, 
[IEquatable<CMsgGCToClientPlayerBeaconState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPlayerBeaconState\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPlayerBeaconState\>\(CMsgGCToClientPlayerBeaconState, params CMsgGCToClientPlayerBeaconState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState__ctor"></a> CMsgGCToClientPlayerBeaconState\(\)

```csharp
public CMsgGCToClientPlayerBeaconState()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_"></a> CMsgGCToClientPlayerBeaconState\(CMsgGCToClientPlayerBeaconState\)

```csharp
public CMsgGCToClientPlayerBeaconState(CMsgGCToClientPlayerBeaconState other)
```

#### Parameters

`other` [CMsgGCToClientPlayerBeaconState](Divine.Protobufs.Dota2.CMsgGCToClientPlayerBeaconState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_NumActiveBeaconsFieldNumber"></a> NumActiveBeaconsFieldNumber

```csharp
public const int NumActiveBeaconsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_NumActiveBeacons"></a> NumActiveBeacons

```csharp
public RepeatedField<int> NumActiveBeacons { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPlayerBeaconState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPlayerBeaconState](Divine.Protobufs.Dota2.CMsgGCToClientPlayerBeaconState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPlayerBeaconState Clone()
```

#### Returns

 [CMsgGCToClientPlayerBeaconState](Divine.Protobufs.Dota2.CMsgGCToClientPlayerBeaconState.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_"></a> Equals\(CMsgGCToClientPlayerBeaconState\)

```csharp
public bool Equals(CMsgGCToClientPlayerBeaconState other)
```

#### Parameters

`other` [CMsgGCToClientPlayerBeaconState](Divine.Protobufs.Dota2.CMsgGCToClientPlayerBeaconState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_"></a> MergeFrom\(CMsgGCToClientPlayerBeaconState\)

```csharp
public void MergeFrom(CMsgGCToClientPlayerBeaconState other)
```

#### Parameters

`other` [CMsgGCToClientPlayerBeaconState](Divine.Protobufs.Dota2.CMsgGCToClientPlayerBeaconState.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlayerBeaconState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

