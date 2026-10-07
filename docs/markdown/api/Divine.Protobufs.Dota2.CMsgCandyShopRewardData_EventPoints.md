# <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints"></a> Class CMsgCandyShopRewardData\_EventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopRewardData_EventPoints : IMessage<CMsgCandyShopRewardData_EventPoints>, IEquatable<CMsgCandyShopRewardData_EventPoints>, IDeepCloneable<CMsgCandyShopRewardData_EventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)

#### Implements

IMessage<CMsgCandyShopRewardData\_EventPoints\>, 
[IEquatable<CMsgCandyShopRewardData\_EventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopRewardData\_EventPoints\>, 
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
[EnumerableExtensions.In<CMsgCandyShopRewardData\_EventPoints\>\(CMsgCandyShopRewardData\_EventPoints, params CMsgCandyShopRewardData\_EventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints__ctor"></a> CMsgCandyShopRewardData\_EventPoints\(\)

```csharp
public CMsgCandyShopRewardData_EventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints__ctor_Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_"></a> CMsgCandyShopRewardData\_EventPoints\(CMsgCandyShopRewardData\_EventPoints\)

```csharp
public CMsgCandyShopRewardData_EventPoints(CMsgCandyShopRewardData_EventPoints other)
```

#### Parameters

`other` [CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_PointsFieldNumber"></a> PointsFieldNumber

```csharp
public const int PointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_HasPoints"></a> HasPoints

```csharp
public bool HasPoints { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopRewardData_EventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_Points"></a> Points

```csharp
public uint Points { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_ClearPoints"></a> ClearPoints\(\)

```csharp
public void ClearPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopRewardData_EventPoints Clone()
```

#### Returns

 [CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_Equals_Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_"></a> Equals\(CMsgCandyShopRewardData\_EventPoints\)

```csharp
public bool Equals(CMsgCandyShopRewardData_EventPoints other)
```

#### Parameters

`other` [CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_"></a> MergeFrom\(CMsgCandyShopRewardData\_EventPoints\)

```csharp
public void MergeFrom(CMsgCandyShopRewardData_EventPoints other)
```

#### Parameters

`other` [CMsgCandyShopRewardData\_EventPoints](Divine.Protobufs.Dota2.CMsgCandyShopRewardData\_EventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopRewardData_EventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

