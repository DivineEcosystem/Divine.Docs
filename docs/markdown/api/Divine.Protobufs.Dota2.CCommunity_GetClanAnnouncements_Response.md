# <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response"></a> Class CCommunity\_GetClanAnnouncements\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCommunity_GetClanAnnouncements_Response : IMessage<CCommunity_GetClanAnnouncements_Response>, IEquatable<CCommunity_GetClanAnnouncements_Response>, IDeepCloneable<CCommunity_GetClanAnnouncements_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCommunity\_GetClanAnnouncements\_Response](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Response.md)

#### Implements

IMessage<CCommunity\_GetClanAnnouncements\_Response\>, 
[IEquatable<CCommunity\_GetClanAnnouncements\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCommunity\_GetClanAnnouncements\_Response\>, 
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
[EnumerableExtensions.In<CCommunity\_GetClanAnnouncements\_Response\>\(CCommunity\_GetClanAnnouncements\_Response, params CCommunity\_GetClanAnnouncements\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response__ctor"></a> CCommunity\_GetClanAnnouncements\_Response\(\)

```csharp
public CCommunity_GetClanAnnouncements_Response()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response__ctor_Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_"></a> CCommunity\_GetClanAnnouncements\_Response\(CCommunity\_GetClanAnnouncements\_Response\)

```csharp
public CCommunity_GetClanAnnouncements_Response(CCommunity_GetClanAnnouncements_Response other)
```

#### Parameters

`other` [CCommunity\_GetClanAnnouncements\_Response](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_AnnouncementsFieldNumber"></a> AnnouncementsFieldNumber

```csharp
public const int AnnouncementsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_MaxcharsFieldNumber"></a> MaxcharsFieldNumber

```csharp
public const int MaxcharsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_StripHtmlFieldNumber"></a> StripHtmlFieldNumber

```csharp
public const int StripHtmlFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Announcements"></a> Announcements

```csharp
public RepeatedField<CCommunity_ClanAnnouncementInfo> Announcements { get; }
```

#### Property Value

 RepeatedField<[CCommunity\_ClanAnnouncementInfo](Divine.Protobufs.Dota2.CCommunity\_ClanAnnouncementInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_HasMaxchars"></a> HasMaxchars

```csharp
public bool HasMaxchars { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_HasStripHtml"></a> HasStripHtml

```csharp
public bool HasStripHtml { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Maxchars"></a> Maxchars

```csharp
public uint Maxchars { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Parser"></a> Parser

```csharp
public static MessageParser<CCommunity_GetClanAnnouncements_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CCommunity\_GetClanAnnouncements\_Response](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Response.md)\>

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_StripHtml"></a> StripHtml

```csharp
public bool StripHtml { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_ClearMaxchars"></a> ClearMaxchars\(\)

```csharp
public void ClearMaxchars()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_ClearStripHtml"></a> ClearStripHtml\(\)

```csharp
public void ClearStripHtml()
```

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Clone"></a> Clone\(\)

```csharp
public CCommunity_GetClanAnnouncements_Response Clone()
```

#### Returns

 [CCommunity\_GetClanAnnouncements\_Response](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Response.md)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_Equals_Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_"></a> Equals\(CCommunity\_GetClanAnnouncements\_Response\)

```csharp
public bool Equals(CCommunity_GetClanAnnouncements_Response other)
```

#### Parameters

`other` [CCommunity\_GetClanAnnouncements\_Response](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_MergeFrom_Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_"></a> MergeFrom\(CCommunity\_GetClanAnnouncements\_Response\)

```csharp
public void MergeFrom(CCommunity_GetClanAnnouncements_Response other)
```

#### Parameters

`other` [CCommunity\_GetClanAnnouncements\_Response](Divine.Protobufs.Dota2.CCommunity\_GetClanAnnouncements\_Response.md)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCommunity_GetClanAnnouncements_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

