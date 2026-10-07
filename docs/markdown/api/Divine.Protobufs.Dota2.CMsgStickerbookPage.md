# <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage"></a> Class CMsgStickerbookPage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStickerbookPage : IMessage<CMsgStickerbookPage>, IEquatable<CMsgStickerbookPage>, IDeepCloneable<CMsgStickerbookPage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)

#### Implements

IMessage<CMsgStickerbookPage\>, 
[IEquatable<CMsgStickerbookPage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStickerbookPage\>, 
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
[EnumerableExtensions.In<CMsgStickerbookPage\>\(CMsgStickerbookPage, params CMsgStickerbookPage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage__ctor"></a> CMsgStickerbookPage\(\)

```csharp
public CMsgStickerbookPage()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage__ctor_Divine_Protobufs_Dota2_CMsgStickerbookPage_"></a> CMsgStickerbookPage\(CMsgStickerbookPage\)

```csharp
public CMsgStickerbookPage(CMsgStickerbookPage other)
```

#### Parameters

`other` [CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_PageNumFieldNumber"></a> PageNumFieldNumber

```csharp
public const int PageNumFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_PageTypeFieldNumber"></a> PageTypeFieldNumber

```csharp
public const int PageTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_StickersFieldNumber"></a> StickersFieldNumber

```csharp
public const int StickersFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_HasPageNum"></a> HasPageNum

```csharp
public bool HasPageNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_HasPageType"></a> HasPageType

```csharp
public bool HasPageType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_PageNum"></a> PageNum

```csharp
public uint PageNum { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_PageType"></a> PageType

```csharp
public EStickerbookPageType PageType { get; set; }
```

#### Property Value

 [EStickerbookPageType](Divine.Protobufs.Dota2.EStickerbookPageType.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStickerbookPage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_Stickers"></a> Stickers

```csharp
public RepeatedField<CMsgStickerbookSticker> Stickers { get; }
```

#### Property Value

 RepeatedField<[CMsgStickerbookSticker](Divine.Protobufs.Dota2.CMsgStickerbookSticker.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_ClearPageNum"></a> ClearPageNum\(\)

```csharp
public void ClearPageNum()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_ClearPageType"></a> ClearPageType\(\)

```csharp
public void ClearPageType()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_Clone"></a> Clone\(\)

```csharp
public CMsgStickerbookPage Clone()
```

#### Returns

 [CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_Equals_Divine_Protobufs_Dota2_CMsgStickerbookPage_"></a> Equals\(CMsgStickerbookPage\)

```csharp
public bool Equals(CMsgStickerbookPage other)
```

#### Parameters

`other` [CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_MergeFrom_Divine_Protobufs_Dota2_CMsgStickerbookPage_"></a> MergeFrom\(CMsgStickerbookPage\)

```csharp
public void MergeFrom(CMsgStickerbookPage other)
```

#### Parameters

`other` [CMsgStickerbookPage](Divine.Protobufs.Dota2.CMsgStickerbookPage.md)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStickerbookPage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

