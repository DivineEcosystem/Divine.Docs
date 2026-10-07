# <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo"></a> Class CMsgShowcaseModerationInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseModerationInfo : IMessage<CMsgShowcaseModerationInfo>, IEquatable<CMsgShowcaseModerationInfo>, IDeepCloneable<CMsgShowcaseModerationInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)

#### Implements

IMessage<CMsgShowcaseModerationInfo\>, 
[IEquatable<CMsgShowcaseModerationInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseModerationInfo\>, 
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
[EnumerableExtensions.In<CMsgShowcaseModerationInfo\>\(CMsgShowcaseModerationInfo, params CMsgShowcaseModerationInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo__ctor"></a> CMsgShowcaseModerationInfo\(\)

```csharp
public CMsgShowcaseModerationInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo__ctor_Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_"></a> CMsgShowcaseModerationInfo\(CMsgShowcaseModerationInfo\)

```csharp
public CMsgShowcaseModerationInfo(CMsgShowcaseModerationInfo other)
```

#### Parameters

`other` [CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ShowcaseTimestampFieldNumber"></a> ShowcaseTimestampFieldNumber

```csharp
public const int ShowcaseTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ShowcaseTypeFieldNumber"></a> ShowcaseTypeFieldNumber

```csharp
public const int ShowcaseTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_HasShowcaseTimestamp"></a> HasShowcaseTimestamp

```csharp
public bool HasShowcaseTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_HasShowcaseType"></a> HasShowcaseType

```csharp
public bool HasShowcaseType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseModerationInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ShowcaseTimestamp"></a> ShowcaseTimestamp

```csharp
public uint ShowcaseTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ShowcaseType"></a> ShowcaseType

```csharp
public EShowcaseType ShowcaseType { get; set; }
```

#### Property Value

 [EShowcaseType](Divine.Protobufs.Dota2.EShowcaseType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ClearShowcaseTimestamp"></a> ClearShowcaseTimestamp\(\)

```csharp
public void ClearShowcaseTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ClearShowcaseType"></a> ClearShowcaseType\(\)

```csharp
public void ClearShowcaseType()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseModerationInfo Clone()
```

#### Returns

 [CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_Equals_Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_"></a> Equals\(CMsgShowcaseModerationInfo\)

```csharp
public bool Equals(CMsgShowcaseModerationInfo other)
```

#### Parameters

`other` [CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_"></a> MergeFrom\(CMsgShowcaseModerationInfo\)

```csharp
public void MergeFrom(CMsgShowcaseModerationInfo other)
```

#### Parameters

`other` [CMsgShowcaseModerationInfo](Divine.Protobufs.Dota2.CMsgShowcaseModerationInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseModerationInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

