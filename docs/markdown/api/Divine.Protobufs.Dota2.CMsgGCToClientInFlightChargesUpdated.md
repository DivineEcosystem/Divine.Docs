# <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated"></a> Class CMsgGCToClientInFlightChargesUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientInFlightChargesUpdated : IMessage<CMsgGCToClientInFlightChargesUpdated>, IEquatable<CMsgGCToClientInFlightChargesUpdated>, IDeepCloneable<CMsgGCToClientInFlightChargesUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md)

#### Implements

IMessage<CMsgGCToClientInFlightChargesUpdated\>, 
[IEquatable<CMsgGCToClientInFlightChargesUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientInFlightChargesUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientInFlightChargesUpdated\>\(CMsgGCToClientInFlightChargesUpdated, params CMsgGCToClientInFlightChargesUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated__ctor"></a> CMsgGCToClientInFlightChargesUpdated\(\)

```csharp
public CMsgGCToClientInFlightChargesUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_"></a> CMsgGCToClientInFlightChargesUpdated\(CMsgGCToClientInFlightChargesUpdated\)

```csharp
public CMsgGCToClientInFlightChargesUpdated(CMsgGCToClientInFlightChargesUpdated other)
```

#### Parameters

`other` [CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_InFlightChargesFieldNumber"></a> InFlightChargesFieldNumber

```csharp
public const int InFlightChargesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_InFlightCharges"></a> InFlightCharges

```csharp
public RepeatedField<CMsgGCToClientInFlightChargesUpdated.Types.ItemCharges> InFlightCharges { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.Types.md).[ItemCharges](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.Types.ItemCharges.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientInFlightChargesUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientInFlightChargesUpdated Clone()
```

#### Returns

 [CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_"></a> Equals\(CMsgGCToClientInFlightChargesUpdated\)

```csharp
public bool Equals(CMsgGCToClientInFlightChargesUpdated other)
```

#### Parameters

`other` [CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_"></a> MergeFrom\(CMsgGCToClientInFlightChargesUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientInFlightChargesUpdated other)
```

#### Parameters

`other` [CMsgGCToClientInFlightChargesUpdated](Divine.Protobufs.Dota2.CMsgGCToClientInFlightChargesUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientInFlightChargesUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

