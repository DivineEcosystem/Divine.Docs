# <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent"></a> Class CMsgClientToGCReportGuildContent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCReportGuildContent : IMessage<CMsgClientToGCReportGuildContent>, IEquatable<CMsgClientToGCReportGuildContent>, IDeepCloneable<CMsgClientToGCReportGuildContent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCReportGuildContent](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContent.md)

#### Implements

IMessage<CMsgClientToGCReportGuildContent\>, 
[IEquatable<CMsgClientToGCReportGuildContent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCReportGuildContent\>, 
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
[EnumerableExtensions.In<CMsgClientToGCReportGuildContent\>\(CMsgClientToGCReportGuildContent, params CMsgClientToGCReportGuildContent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent__ctor"></a> CMsgClientToGCReportGuildContent\(\)

```csharp
public CMsgClientToGCReportGuildContent()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent__ctor_Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_"></a> CMsgClientToGCReportGuildContent\(CMsgClientToGCReportGuildContent\)

```csharp
public CMsgClientToGCReportGuildContent(CMsgClientToGCReportGuildContent other)
```

#### Parameters

`other` [CMsgClientToGCReportGuildContent](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_GuildContentFlagsFieldNumber"></a> GuildContentFlagsFieldNumber

```csharp
public const int GuildContentFlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_GuildContentFlags"></a> GuildContentFlags

```csharp
public uint GuildContentFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_HasGuildContentFlags"></a> HasGuildContentFlags

```csharp
public bool HasGuildContentFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCReportGuildContent> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCReportGuildContent](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_ClearGuildContentFlags"></a> ClearGuildContentFlags\(\)

```csharp
public void ClearGuildContentFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCReportGuildContent Clone()
```

#### Returns

 [CMsgClientToGCReportGuildContent](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_Equals_Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_"></a> Equals\(CMsgClientToGCReportGuildContent\)

```csharp
public bool Equals(CMsgClientToGCReportGuildContent other)
```

#### Parameters

`other` [CMsgClientToGCReportGuildContent](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_"></a> MergeFrom\(CMsgClientToGCReportGuildContent\)

```csharp
public void MergeFrom(CMsgClientToGCReportGuildContent other)
```

#### Parameters

`other` [CMsgClientToGCReportGuildContent](Divine.Protobufs.Dota2.CMsgClientToGCReportGuildContent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCReportGuildContent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

