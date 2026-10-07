# <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo"></a> Class CMsgSignOutTextMuteInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutTextMuteInfo : IMessage<CMsgSignOutTextMuteInfo>, IEquatable<CMsgSignOutTextMuteInfo>, IDeepCloneable<CMsgSignOutTextMuteInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md)

#### Implements

IMessage<CMsgSignOutTextMuteInfo\>, 
[IEquatable<CMsgSignOutTextMuteInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutTextMuteInfo\>, 
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
[EnumerableExtensions.In<CMsgSignOutTextMuteInfo\>\(CMsgSignOutTextMuteInfo, params CMsgSignOutTextMuteInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo__ctor"></a> CMsgSignOutTextMuteInfo\(\)

```csharp
public CMsgSignOutTextMuteInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo__ctor_Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_"></a> CMsgSignOutTextMuteInfo\(CMsgSignOutTextMuteInfo\)

```csharp
public CMsgSignOutTextMuteInfo(CMsgSignOutTextMuteInfo other)
```

#### Parameters

`other` [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_TextMuteMessagesFieldNumber"></a> TextMuteMessagesFieldNumber

```csharp
public const int TextMuteMessagesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutTextMuteInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_TextMuteMessages"></a> TextMuteMessages

```csharp
public RepeatedField<CMsgSignOutTextMuteInfo.Types.TextMuteMessage> TextMuteMessages { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.md).[TextMuteMessage](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.Types.TextMuteMessage.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutTextMuteInfo Clone()
```

#### Returns

 [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_Equals_Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_"></a> Equals\(CMsgSignOutTextMuteInfo\)

```csharp
public bool Equals(CMsgSignOutTextMuteInfo other)
```

#### Parameters

`other` [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_"></a> MergeFrom\(CMsgSignOutTextMuteInfo\)

```csharp
public void MergeFrom(CMsgSignOutTextMuteInfo other)
```

#### Parameters

`other` [CMsgSignOutTextMuteInfo](Divine.Protobufs.Dota2.CMsgSignOutTextMuteInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutTextMuteInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

