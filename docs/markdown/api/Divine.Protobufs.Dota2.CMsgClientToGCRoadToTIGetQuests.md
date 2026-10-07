# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests"></a> Class CMsgClientToGCRoadToTIGetQuests

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRoadToTIGetQuests : IMessage<CMsgClientToGCRoadToTIGetQuests>, IEquatable<CMsgClientToGCRoadToTIGetQuests>, IDeepCloneable<CMsgClientToGCRoadToTIGetQuests>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRoadToTIGetQuests](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuests.md)

#### Implements

IMessage<CMsgClientToGCRoadToTIGetQuests\>, 
[IEquatable<CMsgClientToGCRoadToTIGetQuests\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRoadToTIGetQuests\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRoadToTIGetQuests\>\(CMsgClientToGCRoadToTIGetQuests, params CMsgClientToGCRoadToTIGetQuests\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests__ctor"></a> CMsgClientToGCRoadToTIGetQuests\(\)

```csharp
public CMsgClientToGCRoadToTIGetQuests()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_"></a> CMsgClientToGCRoadToTIGetQuests\(CMsgClientToGCRoadToTIGetQuests\)

```csharp
public CMsgClientToGCRoadToTIGetQuests(CMsgClientToGCRoadToTIGetQuests other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetQuests](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuests.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRoadToTIGetQuests> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRoadToTIGetQuests](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuests.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRoadToTIGetQuests Clone()
```

#### Returns

 [CMsgClientToGCRoadToTIGetQuests](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuests.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_"></a> Equals\(CMsgClientToGCRoadToTIGetQuests\)

```csharp
public bool Equals(CMsgClientToGCRoadToTIGetQuests other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetQuests](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuests.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_"></a> MergeFrom\(CMsgClientToGCRoadToTIGetQuests\)

```csharp
public void MergeFrom(CMsgClientToGCRoadToTIGetQuests other)
```

#### Parameters

`other` [CMsgClientToGCRoadToTIGetQuests](Divine.Protobufs.Dota2.CMsgClientToGCRoadToTIGetQuests.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRoadToTIGetQuests_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

