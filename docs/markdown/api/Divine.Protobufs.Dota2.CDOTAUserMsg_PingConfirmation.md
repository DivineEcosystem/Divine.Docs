# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation"></a> Class CDOTAUserMsg\_PingConfirmation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_PingConfirmation : IMessage<CDOTAUserMsg_PingConfirmation>, IEquatable<CDOTAUserMsg_PingConfirmation>, IDeepCloneable<CDOTAUserMsg_PingConfirmation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_PingConfirmation](Divine.Protobufs.Dota2.CDOTAUserMsg\_PingConfirmation.md)

#### Implements

IMessage<CDOTAUserMsg\_PingConfirmation\>, 
[IEquatable<CDOTAUserMsg\_PingConfirmation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_PingConfirmation\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_PingConfirmation\>\(CDOTAUserMsg\_PingConfirmation, params CDOTAUserMsg\_PingConfirmation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation__ctor"></a> CDOTAUserMsg\_PingConfirmation\(\)

```csharp
public CDOTAUserMsg_PingConfirmation()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_"></a> CDOTAUserMsg\_PingConfirmation\(CDOTAUserMsg\_PingConfirmation\)

```csharp
public CDOTAUserMsg_PingConfirmation(CDOTAUserMsg_PingConfirmation other)
```

#### Parameters

`other` [CDOTAUserMsg\_PingConfirmation](Divine.Protobufs.Dota2.CDOTAUserMsg\_PingConfirmation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_IconTypeFieldNumber"></a> IconTypeFieldNumber

```csharp
public const int IconTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_PlayerIdOfOriginalPingerFieldNumber"></a> PlayerIdOfOriginalPingerFieldNumber

```csharp
public const int PlayerIdOfOriginalPingerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_EntityIndex"></a> EntityIndex

```csharp
public uint EntityIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_HasIconType"></a> HasIconType

```csharp
public bool HasIconType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_HasPlayerIdOfOriginalPinger"></a> HasPlayerIdOfOriginalPinger

```csharp
public bool HasPlayerIdOfOriginalPinger { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_IconType"></a> IconType

```csharp
public uint IconType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_Location"></a> Location

```csharp
public CMsgVector Location { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_PingConfirmation> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_PingConfirmation](Divine.Protobufs.Dota2.CDOTAUserMsg\_PingConfirmation.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_PlayerIdOfOriginalPinger"></a> PlayerIdOfOriginalPinger

```csharp
public int PlayerIdOfOriginalPinger { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_ClearIconType"></a> ClearIconType\(\)

```csharp
public void ClearIconType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_ClearPlayerIdOfOriginalPinger"></a> ClearPlayerIdOfOriginalPinger\(\)

```csharp
public void ClearPlayerIdOfOriginalPinger()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_PingConfirmation Clone()
```

#### Returns

 [CDOTAUserMsg\_PingConfirmation](Divine.Protobufs.Dota2.CDOTAUserMsg\_PingConfirmation.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_"></a> Equals\(CDOTAUserMsg\_PingConfirmation\)

```csharp
public bool Equals(CDOTAUserMsg_PingConfirmation other)
```

#### Parameters

`other` [CDOTAUserMsg\_PingConfirmation](Divine.Protobufs.Dota2.CDOTAUserMsg\_PingConfirmation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_"></a> MergeFrom\(CDOTAUserMsg\_PingConfirmation\)

```csharp
public void MergeFrom(CDOTAUserMsg_PingConfirmation other)
```

#### Parameters

`other` [CDOTAUserMsg\_PingConfirmation](Divine.Protobufs.Dota2.CDOTAUserMsg\_PingConfirmation.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PingConfirmation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

