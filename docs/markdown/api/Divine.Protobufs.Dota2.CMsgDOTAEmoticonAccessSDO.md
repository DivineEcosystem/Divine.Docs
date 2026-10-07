# <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO"></a> Class CMsgDOTAEmoticonAccessSDO

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAEmoticonAccessSDO : IMessage<CMsgDOTAEmoticonAccessSDO>, IEquatable<CMsgDOTAEmoticonAccessSDO>, IDeepCloneable<CMsgDOTAEmoticonAccessSDO>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAEmoticonAccessSDO](Divine.Protobufs.Dota2.CMsgDOTAEmoticonAccessSDO.md)

#### Implements

IMessage<CMsgDOTAEmoticonAccessSDO\>, 
[IEquatable<CMsgDOTAEmoticonAccessSDO\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAEmoticonAccessSDO\>, 
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
[EnumerableExtensions.In<CMsgDOTAEmoticonAccessSDO\>\(CMsgDOTAEmoticonAccessSDO, params CMsgDOTAEmoticonAccessSDO\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO__ctor"></a> CMsgDOTAEmoticonAccessSDO\(\)

```csharp
public CMsgDOTAEmoticonAccessSDO()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO__ctor_Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_"></a> CMsgDOTAEmoticonAccessSDO\(CMsgDOTAEmoticonAccessSDO\)

```csharp
public CMsgDOTAEmoticonAccessSDO(CMsgDOTAEmoticonAccessSDO other)
```

#### Parameters

`other` [CMsgDOTAEmoticonAccessSDO](Divine.Protobufs.Dota2.CMsgDOTAEmoticonAccessSDO.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_UnlockedEmoticonsFieldNumber"></a> UnlockedEmoticonsFieldNumber

```csharp
public const int UnlockedEmoticonsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_HasUnlockedEmoticons"></a> HasUnlockedEmoticons

```csharp
public bool HasUnlockedEmoticons { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAEmoticonAccessSDO> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAEmoticonAccessSDO](Divine.Protobufs.Dota2.CMsgDOTAEmoticonAccessSDO.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_UnlockedEmoticons"></a> UnlockedEmoticons

```csharp
public ByteString UnlockedEmoticons { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_ClearUnlockedEmoticons"></a> ClearUnlockedEmoticons\(\)

```csharp
public void ClearUnlockedEmoticons()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAEmoticonAccessSDO Clone()
```

#### Returns

 [CMsgDOTAEmoticonAccessSDO](Divine.Protobufs.Dota2.CMsgDOTAEmoticonAccessSDO.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_Equals_Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_"></a> Equals\(CMsgDOTAEmoticonAccessSDO\)

```csharp
public bool Equals(CMsgDOTAEmoticonAccessSDO other)
```

#### Parameters

`other` [CMsgDOTAEmoticonAccessSDO](Divine.Protobufs.Dota2.CMsgDOTAEmoticonAccessSDO.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_"></a> MergeFrom\(CMsgDOTAEmoticonAccessSDO\)

```csharp
public void MergeFrom(CMsgDOTAEmoticonAccessSDO other)
```

#### Parameters

`other` [CMsgDOTAEmoticonAccessSDO](Divine.Protobufs.Dota2.CMsgDOTAEmoticonAccessSDO.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEmoticonAccessSDO_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

