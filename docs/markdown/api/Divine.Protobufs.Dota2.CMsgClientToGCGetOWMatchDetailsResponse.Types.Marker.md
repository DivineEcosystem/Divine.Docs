# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker"></a> Class CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker : IMessage<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker>, IEquatable<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker>, IDeepCloneable<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)

#### Implements

IMessage<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker\>, 
[IEquatable<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker\>\(CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker, params CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker__ctor"></a> Marker\(\)

```csharp
public Marker()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_"></a> Marker\(Marker\)

```csharp
public Marker(CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_EndGameTimeSFieldNumber"></a> EndGameTimeSFieldNumber

```csharp
public const int EndGameTimeSFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_StartGameTimeSFieldNumber"></a> StartGameTimeSFieldNumber

```csharp
public const int StartGameTimeSFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_EndGameTimeS"></a> EndGameTimeS

```csharp
public uint EndGameTimeS { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_HasEndGameTimeS"></a> HasEndGameTimeS

```csharp
public bool HasEndGameTimeS { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_HasStartGameTimeS"></a> HasStartGameTimeS

```csharp
public bool HasStartGameTimeS { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_StartGameTimeS"></a> StartGameTimeS

```csharp
public uint StartGameTimeS { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_ClearEndGameTimeS"></a> ClearEndGameTimeS\(\)

```csharp
public void ClearEndGameTimeS()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_ClearStartGameTimeS"></a> ClearStartGameTimeS\(\)

```csharp
public void ClearStartGameTimeS()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker Clone()
```

#### Returns

 [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_"></a> Equals\(Marker\)

```csharp
public bool Equals(CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_"></a> MergeFrom\(Marker\)

```csharp
public void MergeFrom(CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetailsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.md).[Marker](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetailsResponse.Types.Marker.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetailsResponse_Types_Marker_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

