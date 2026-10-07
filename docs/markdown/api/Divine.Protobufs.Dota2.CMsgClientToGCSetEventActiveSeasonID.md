# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID"></a> Class CMsgClientToGCSetEventActiveSeasonID

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetEventActiveSeasonID : IMessage<CMsgClientToGCSetEventActiveSeasonID>, IEquatable<CMsgClientToGCSetEventActiveSeasonID>, IDeepCloneable<CMsgClientToGCSetEventActiveSeasonID>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetEventActiveSeasonID](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonID.md)

#### Implements

IMessage<CMsgClientToGCSetEventActiveSeasonID\>, 
[IEquatable<CMsgClientToGCSetEventActiveSeasonID\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetEventActiveSeasonID\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetEventActiveSeasonID\>\(CMsgClientToGCSetEventActiveSeasonID, params CMsgClientToGCSetEventActiveSeasonID\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID__ctor"></a> CMsgClientToGCSetEventActiveSeasonID\(\)

```csharp
public CMsgClientToGCSetEventActiveSeasonID()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_"></a> CMsgClientToGCSetEventActiveSeasonID\(CMsgClientToGCSetEventActiveSeasonID\)

```csharp
public CMsgClientToGCSetEventActiveSeasonID(CMsgClientToGCSetEventActiveSeasonID other)
```

#### Parameters

`other` [CMsgClientToGCSetEventActiveSeasonID](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonID.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_ActiveSeasonIdFieldNumber"></a> ActiveSeasonIdFieldNumber

```csharp
public const int ActiveSeasonIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_ActiveSeasonId"></a> ActiveSeasonId

```csharp
public uint ActiveSeasonId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_HasActiveSeasonId"></a> HasActiveSeasonId

```csharp
public bool HasActiveSeasonId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetEventActiveSeasonID> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetEventActiveSeasonID](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonID.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_ClearActiveSeasonId"></a> ClearActiveSeasonId\(\)

```csharp
public void ClearActiveSeasonId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetEventActiveSeasonID Clone()
```

#### Returns

 [CMsgClientToGCSetEventActiveSeasonID](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonID.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_"></a> Equals\(CMsgClientToGCSetEventActiveSeasonID\)

```csharp
public bool Equals(CMsgClientToGCSetEventActiveSeasonID other)
```

#### Parameters

`other` [CMsgClientToGCSetEventActiveSeasonID](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonID.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_"></a> MergeFrom\(CMsgClientToGCSetEventActiveSeasonID\)

```csharp
public void MergeFrom(CMsgClientToGCSetEventActiveSeasonID other)
```

#### Parameters

`other` [CMsgClientToGCSetEventActiveSeasonID](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonID.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonID_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

