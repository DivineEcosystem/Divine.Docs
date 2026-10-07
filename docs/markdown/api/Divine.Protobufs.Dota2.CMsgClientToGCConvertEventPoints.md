# <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints"></a> Class CMsgClientToGCConvertEventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCConvertEventPoints : IMessage<CMsgClientToGCConvertEventPoints>, IEquatable<CMsgClientToGCConvertEventPoints>, IDeepCloneable<CMsgClientToGCConvertEventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCConvertEventPoints](Divine.Protobufs.Dota2.CMsgClientToGCConvertEventPoints.md)

#### Implements

IMessage<CMsgClientToGCConvertEventPoints\>, 
[IEquatable<CMsgClientToGCConvertEventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCConvertEventPoints\>, 
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
[EnumerableExtensions.In<CMsgClientToGCConvertEventPoints\>\(CMsgClientToGCConvertEventPoints, params CMsgClientToGCConvertEventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints__ctor"></a> CMsgClientToGCConvertEventPoints\(\)

```csharp
public CMsgClientToGCConvertEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints__ctor_Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_"></a> CMsgClientToGCConvertEventPoints\(CMsgClientToGCConvertEventPoints\)

```csharp
public CMsgClientToGCConvertEventPoints(CMsgClientToGCConvertEventPoints other)
```

#### Parameters

`other` [CMsgClientToGCConvertEventPoints](Divine.Protobufs.Dota2.CMsgClientToGCConvertEventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_EventIdPointsToBuyFieldNumber"></a> EventIdPointsToBuyFieldNumber

```csharp
public const int EventIdPointsToBuyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_EventIdPointsToSpendFieldNumber"></a> EventIdPointsToSpendFieldNumber

```csharp
public const int EventIdPointsToSpendFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_NumPointsToBuyFieldNumber"></a> NumPointsToBuyFieldNumber

```csharp
public const int NumPointsToBuyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_NumPointsToSpendFieldNumber"></a> NumPointsToSpendFieldNumber

```csharp
public const int NumPointsToSpendFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_EventIdPointsToBuy"></a> EventIdPointsToBuy

```csharp
public EEvent EventIdPointsToBuy { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_EventIdPointsToSpend"></a> EventIdPointsToSpend

```csharp
public EEvent EventIdPointsToSpend { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_HasEventIdPointsToBuy"></a> HasEventIdPointsToBuy

```csharp
public bool HasEventIdPointsToBuy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_HasEventIdPointsToSpend"></a> HasEventIdPointsToSpend

```csharp
public bool HasEventIdPointsToSpend { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_HasNumPointsToBuy"></a> HasNumPointsToBuy

```csharp
public bool HasNumPointsToBuy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_HasNumPointsToSpend"></a> HasNumPointsToSpend

```csharp
public bool HasNumPointsToSpend { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_NumPointsToBuy"></a> NumPointsToBuy

```csharp
public uint NumPointsToBuy { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_NumPointsToSpend"></a> NumPointsToSpend

```csharp
public uint NumPointsToSpend { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCConvertEventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCConvertEventPoints](Divine.Protobufs.Dota2.CMsgClientToGCConvertEventPoints.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_ClearEventIdPointsToBuy"></a> ClearEventIdPointsToBuy\(\)

```csharp
public void ClearEventIdPointsToBuy()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_ClearEventIdPointsToSpend"></a> ClearEventIdPointsToSpend\(\)

```csharp
public void ClearEventIdPointsToSpend()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_ClearNumPointsToBuy"></a> ClearNumPointsToBuy\(\)

```csharp
public void ClearNumPointsToBuy()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_ClearNumPointsToSpend"></a> ClearNumPointsToSpend\(\)

```csharp
public void ClearNumPointsToSpend()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCConvertEventPoints Clone()
```

#### Returns

 [CMsgClientToGCConvertEventPoints](Divine.Protobufs.Dota2.CMsgClientToGCConvertEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_Equals_Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_"></a> Equals\(CMsgClientToGCConvertEventPoints\)

```csharp
public bool Equals(CMsgClientToGCConvertEventPoints other)
```

#### Parameters

`other` [CMsgClientToGCConvertEventPoints](Divine.Protobufs.Dota2.CMsgClientToGCConvertEventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_"></a> MergeFrom\(CMsgClientToGCConvertEventPoints\)

```csharp
public void MergeFrom(CMsgClientToGCConvertEventPoints other)
```

#### Parameters

`other` [CMsgClientToGCConvertEventPoints](Divine.Protobufs.Dota2.CMsgClientToGCConvertEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCConvertEventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

